using System.Threading.Tasks;
using AlienJust.Support.UI.Contracts;

namespace AlienJust.Support.Avalonia
{
    public interface IWindowSystemAsync
    {
        Task<string> ShowOpenFileDialogAsync(string dialogTitle, string filter);

        Task<string> ShowSaveFileDialogAsync(string dialogTitle, string filter);

        Task<BinaryChoise> ShowYesNoDialogAsync(string message, string caption);

        Task ShowMessageBoxAsync(string message, string caption);
    }
}
