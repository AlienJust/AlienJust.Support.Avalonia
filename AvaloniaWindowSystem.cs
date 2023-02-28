﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlienJust.Support.UI.Contracts;
using Avalonia.Controls;
using Avalonia.Platform.Storage;
using MessageBox.Avalonia;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;

namespace AlienJust.Support.Avalonia
{

    public sealed class AvaloniaWindowSystem : IWindowSystemAsync
    {
        private Window _window;

        public AvaloniaWindowSystem(Window window)
        {
            _window = window;
        }

        private static List<FilePickerFileType> ParseFilters(string filter)
        {
            var parts = filter.Split('|');
            var filters = new List<FilePickerFileType>();
            if (parts.Length % 2 == 0)
            {
                for (int i = 0; i < parts.Length; i += 2)
                {
                    var f = new FilePickerFileType(parts[i])
                    {
                        Patterns = new List<string> { parts[i + 1] }
                    };
                    filters.Add(f);
                }
            }
            return filters;
        }
        public async Task<string> ShowOpenFileDialogAsync(string dialogTitle, string filter)
        {
            var result = await _window.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions() { Title = dialogTitle, FileTypeFilter = ParseFilters(filter), AllowMultiple = false });

            if (result != null && result.Count > 0)
            {
                return result[0].Path.AbsolutePath;
            }
            return null;
        }

        public async Task<string[]> ShowOpenFilesDialogAsync(string dialogTitle, string filter)
        {
            var result = await _window.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions() { Title = dialogTitle, FileTypeFilter = ParseFilters(filter), AllowMultiple = true });
            
            if (result == null || result.Count == 0) return Array.Empty<string>();
            else 
            {
                return result.Select(item => item.Path.AbsolutePath).ToArray();
            }
        }

        public async Task<string> ShowOpenFolderDialogAsync(string dialogTitle, string defaultDirectory = null)
        {
            var options = new FolderPickerOpenOptions() { Title = dialogTitle };
            // TODO: defaultDirectory
            //options.SuggestedStartLocation = new BclStorageFolder();
            var result = await _window.StorageProvider.OpenFolderPickerAsync(options);

            return result == null || result.Count != 1 ? null : result[0].Path.AbsolutePath;
        }

        public async Task<string> ShowSaveFileDialogAsync(string dialogTitle, string filter)
        {
            var result = await _window.StorageProvider.SaveFilePickerAsync(new FilePickerSaveOptions() { Title = dialogTitle, FileTypeChoices = ParseFilters(filter) });
            return result?.Path.AbsolutePath;
        }

        public async Task ShowMessageBoxAsync(string message, string caption)
        {
            var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(caption, message);
            await messageBoxStandardWindow.Show();
        }

        public async Task<BinaryChoise> ShowYesNoDialogAsync(string message, string caption)
        {
            var msBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow(
                new MessageBoxStandardParams
                {
                    ButtonDefinitions = ButtonEnum.YesNo,
                    ContentTitle = caption,
                    ContentMessage = message,
                    Icon = Icon.Info,
                    //Style = Style.UbuntuLinux
                });
            var result = await msBoxStandardWindow.Show();
            switch (result)
            {
                case ButtonResult.Yes:
                    return BinaryChoise.Yes;
                case ButtonResult.No:
                    return BinaryChoise.No;
                default:
                    throw new Exception("Unexpected dialog result");
            }
        }
    }
}
