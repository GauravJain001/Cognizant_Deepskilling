using System;
namespace code
{
    interface Stock
    {
        public void Register(Observer o);
        public void DeRegister(Observer o);
        public void Notify();
    }
}