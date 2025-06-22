using System;
namespace code
{
    class RemoteControl
    {
        private ICommand ?command;
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }
        public void ExecuteCommand()
        {
            command?.execute();
        }
    }
}