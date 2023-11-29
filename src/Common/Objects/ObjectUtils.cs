using System.Runtime.CompilerServices;

namespace Common.Objects
{
    public static class ObjectUtils
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TValue Swap<TValue>(ref TValue valueRef, TValue value)
        {
            var valueSwap = valueRef;

            valueRef = value;

            return valueSwap;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Swap<TValue>(ref TValue valueRef1, ref TValue valueRef2)
        {
            var valueSwap = valueRef2;

            valueRef2 = valueRef1;
            valueRef1 = valueSwap;
        }
    }
}
