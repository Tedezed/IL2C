using System;
using System.Runtime.CompilerServices;

namespace IL2C.ILConverters
{
    [Case("ABC", "Value")]
    public sealed class Ldstr
    {
        [MethodImpl(MethodImplOptions.ForwardRef)]
        public static extern string Value();
    }
}
