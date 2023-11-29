using System.Buffers;
using System.Buffers.Binary;

namespace Common.Buffers.Extensions
{

    public static class BinaryBufferWriterExtensions
    {
        public static void WriteUInt16BigEndian(this IBufferWriter<byte> writer, ushort value)
        {
            var spanSize = 2;
            var span = writer.GetSpan(spanSize);

            BinaryPrimitives.WriteUInt16BigEndian(span, value);

            writer.Advance(spanSize);
        }

        public static void WriteUInt32BigEndian(this IBufferWriter<byte> writer, uint value)
        {
            var spanSize = 4;
            var span = writer.GetSpan(spanSize);

            BinaryPrimitives.WriteUInt32BigEndian(span, value);

            writer.Advance(spanSize);
        }
    }
}