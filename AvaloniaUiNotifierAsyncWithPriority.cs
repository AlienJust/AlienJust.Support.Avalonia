using System;
using Avalonia.Threading;
using AlienJust.Support.Concurrent.Contracts;

namespace AlienJust.Support.Wpf
{
    public sealed class AvaloniaUiNotifierAsyncWithPriority : IThreadNotifier
    {
        private readonly Dispatcher _dispatcher;
        private readonly DispatcherPriority _priority;

        public AvaloniaUiNotifierAsyncWithPriority(Dispatcher dispatcher, DispatcherPriority priority)
        {
            _dispatcher = dispatcher;
            _priority = priority;
        }

        public void Notify(Action notifyAction)
        {
            _dispatcher.BeginInvoke(notifyAction, _priority);
        }
    }
}