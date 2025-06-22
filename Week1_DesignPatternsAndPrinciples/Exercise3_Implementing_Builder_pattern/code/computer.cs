using System;
namespace code
{
    class Computer
    {
        private string ?Ram;
        private string ?Cpu;
        private string ?Storage;
        private Computer(Builder builder)
        {
            this.Ram = builder.Ram;
            this.Cpu = builder.Cpu;
            this.Storage = builder.Storage;

        }

        public class Builder
        {
            public String ?Cpu, Ram, Storage;
            public Builder WithCpu(String Cpu)
            {
                this.Cpu = Cpu;
                return this;
            }
            public Builder WithRam(String Ram)
            {
                this.Ram = Ram;
                return this;
            }
            public Builder WithStorage(String Storage)
            {
                this.Storage = Storage;
                return this;
            }
            public Computer Build()
            {
                return new Computer(this);
            }
        }
        public override string ToString()
        {
            return $"Ram -{Ram}, Storage = {Storage}, CPU - {Cpu}";
        }
        
    }
}