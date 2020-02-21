using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_CSharp
{
    interface IPurchasable
    {
        int Cost { get; set; }
        string Purchase();
    }
}
