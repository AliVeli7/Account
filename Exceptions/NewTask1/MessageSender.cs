using System;
using System.Collections.Generic;
using System.Text;

namespace NewTask1
{
    public abstract class MessageSender {

        public string Adress;
        public string Password;
        public bool FingerPrintSecurity = false;
        public abstract void SendMessage();
    }
}
