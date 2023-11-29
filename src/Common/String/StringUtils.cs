using System.Runtime.CompilerServices;

namespace Common.String
{
    public static class StringUtils
    {
        public static string ToHex(ReadOnlySpan<byte> bytes)
        {
            var charsLength = bytes.Length * 2;
            var chars = charsLength <= 1024 ? stackalloc char[charsLength] : new char[charsLength];

            for (var index = 0; index < bytes.Length; ++index)
            {
                var chr = bytes[index];
                var chrIndex = index * 2;

                chars[chrIndex] = ToNibble(chr >> 4);
                chars[chrIndex + 1] = ToNibble(chr);
            }

            return new string(chars);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToNibble(int value)
        {
            value &= 0xF;

            if (value >= 10)
            {
                return (char)(value - 10 + 'a');
            }

            return (char)(value + '0');
        }
    }
}
