using System;
namespace code
{
    class computer
    {
        private string ram;
        private string cpu;
        private string storage;
        private computer() { }

        static class Builder
        {
            computer comp = new computer();

            public Builder withRam(string ram)
            {
                comp.ram = ram;
                return this;
            }
            public Builder withStorage(string storage)
            {
                comp.storage = storage;
                return this;
            }
            public Builder withCpu(string cpu)
            {
                comp.cpu = cpu;
                return this;
            }
            public computer build()
            {
                //validations
                return comp;
            }
        }

        
    }
}