using System;
namespace code
{
    class LightOffCommand:ICommand
    {
        private Light light;
        public LightOffCommand(Light light)
        {
            this.light = light;
            
        }
        public void execute()
        {
            light.Off();
        }
    }
}