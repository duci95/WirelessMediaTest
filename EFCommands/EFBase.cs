using System;
using System.Collections.Generic;
using System.Text;
using WirelessMediaTest.EFDataAccess;

namespace WirelessMediaTest.EFCommands
{
    public class EFBase
    {
        protected WirelessMediaTestContext Context { get; }
        protected EFBase(WirelessMediaTestContext context) => Context = context;
    }
}
