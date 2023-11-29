using System.Buffers.Binary;

namespace Common.Buffers.Extensions
{
    public static class BinaryBufferReaderExtensions
    {
        public static ushort ReadUInt16BigEndian(this IBufferReader<byte> reader)
        {
            var valueSpan = reader.Memory.Span[..2];
            var value = BinaryPrimitives.ReadUInt16BigEndian(valueSpan);

            reader.Advance(valueSpan.Length);

            return value;
        }

        public static uint ReadUInt32BigEndian(this IBufferReader<byte> reader)
        {
            var valueSpan = reader.Memory.Span[..4];
            var value = BinaryPrimitives.ReadUInt32BigEndian(valueSpan);

            reader.Advance(valueSpan.Length);

            return value;
        }
    }
}
