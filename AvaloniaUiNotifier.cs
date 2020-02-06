using System;
using Avalonia.Threading;
using AlienJust.Support.Concurrent.Contracts;

namespace AlienJust.Support.Avalonia
{
    public sealed class AvaloniaUiNotifier : IThreadNotifier
    {
        private readonly Dispatcher _dispatcher;

        public AvaloniaUiNotifier(Dispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        public void Notify(Action notifyAction)
        {
            _dispatcher.Invoke(notifyAction);
        }
    }
}
