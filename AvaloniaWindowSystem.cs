using System;
using System.Threading.Tasks;
using Avalonia.Controls;
using AlienJust.Support.UI.Contracts;
using MessageBox.Avalonia;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using System.Collections.Generic;

namespace AlienJust.Support.Avalonia
{

    public sealed class AvaloniaWindowSystem : IWindowSystemAsync
    {
        private Window _window;

        public AvaloniaWindowSystem(Window window)
        {
            _window = window;
        }

        private List<FileDialogFilter> ParseFilters(string filter)
        {
            var parts = filter.Split('|');
            var filters = new List<FileDialogFilter>();
            if (parts.Length %2 == 0)
            {
                for (int i = 0; i < parts.Length; i += 2)
                {
                    var f = new FileDialogFilter();
                    f.Name = parts[i];
                    f.Extensions = new List<string>{parts[i + 1]};
                    filters.Add(f);
                }
            }
            return filters;
        }
        public async Task<string> ShowOpenFileDialogAsync(string dialogTitle, string filter)
        {
            var dialog = new OpenFileDialog { Title = dialogTitle, Filters = ParseFilters(filter) };
            var result = await dialog.ShowAsync(_window);

            if (result != null && result.Length > 0)
            {
                return result[0];
            }
            return null;
        }

        public async Task<string[]> ShowOpenFilesDialogAsync(string dialogTitle, string filter)
        {
            var dialog = new OpenFileDialog { Title = dialogTitle, Filters = ParseFilters(filter) };
            return await dialog.ShowAsync(_window);
        }

        public async Task<string> ShowOpenFolderDialogAsync(string dialogTitle, string defaultDirectory = null)
        {
            var dialog = new OpenFolderDialog { Title = dialogTitle };
            if (defaultDirectory != null) dialog.Directory = defaultDirectory;

            return await dialog.ShowAsync(_window);
        }

        public async Task<string> ShowSaveFileDialogAsync(string dialogTitle, string filter)
        {
            var dialog = new SaveFileDialog { Title = dialogTitle, Filters = ParseFilters(filter) };
            return await dialog.ShowAsync(_window);
            
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
