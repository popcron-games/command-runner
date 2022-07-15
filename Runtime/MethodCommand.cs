using System;

namespace Popcron.CommandRunner
{
    public class MethodCommand : ICommand
    {
        private Action method;

        public string Path { get; }

        public MethodCommand(string path, Action method)
        {
            Path = path;
            this.method = method;
        }

        void ICommand.Run(Context context)
        {
            method?.Invoke();
        }
    }
}