using System;
namespace code
{
    class Test
    {
        public static void Main(String[] args)
        {
            //creating Reciver
            Light light = new Light();
            //Creating Commands
            ICommand Light_On_Command = new LightOnCommand(light);
            ICommand Light_Of_Command = new LightOffCommand(light);
            //creating invoker
            RemoteControl Remote = new RemoteControl();
            //Setting Command and Executing it
            Remote.SetCommand(Light_On_Command);
            Remote.ExecuteCommand();
            //Changing Command
            Remote.SetCommand(Light_Of_Command);
            Remote.ExecuteCommand();

        }
    }
}