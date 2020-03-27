using System;
using System.Collections.Generic;
using System.Text;

namespace WirelessMediaTest.Application
{
    public interface ICommand<Req>
    {
        void Operation(Req req);
    }
    public interface ICommand<Req, Res>
    {
        Res Operation(Req req);
    }
}