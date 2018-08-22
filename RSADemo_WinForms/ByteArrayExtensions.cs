using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Org.BouncyCastle.Math;

namespace RSADemo_WinForms
{
    public static class ByteArrayExtensions
    {
        public static BigInteger ToBigInteger(this byte[] self)
        {
            return new BigInteger(1, self);
        }
    }
}
