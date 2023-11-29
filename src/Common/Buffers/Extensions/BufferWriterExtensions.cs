using System.Buffers;

namespace Common.Buffers.Extensions
{
    public static class BufferWriterExtensions
    {
        public static void Write<T>(this IBufferWriter<T> writer, T value)
        {
            var spanSize = 1;
            var span = writer.GetSpan(spanSize);

            span[0] = value;

            writer.Advance(spanSize);
        }
    }
}