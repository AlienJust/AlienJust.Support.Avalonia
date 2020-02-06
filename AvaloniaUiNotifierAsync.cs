using System;
using Avalonia.Threading;
using AlienJust.Support.Concurrent.Contracts;

namespace AlienJust.Support.Avalonia
{
    public sealed class AvaloniaUiNotifierAsync : IThreadNotifier
    {
        private readonly Dispatcher _dispatcher;

        public AvaloniaUiNotifierAsync(Dispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        public void Notify(Action notifyAction)
        {
            _dispatcher.BeginInvoke(notifyAction);
        }
    }
}