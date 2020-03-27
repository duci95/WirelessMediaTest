using System;
using System.Collections.Generic;
using System.Text;

namespace WirelessMediaTest.Application.Exceptions
{
    public class AlreadyExistsException : Exception
    {
        private string message;

        public AlreadyExistsException(string message)
        {
            this.message = message;
        }
    }
}