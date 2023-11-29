
namespace Common.Buffers.Extensions
{
    public static class BufferReaderExtensions
    {
        public static ReadOnlyMemory<T> ReadAll<T>(this IBufferReader<T> reader)
        {
            var value = reader.Memory;

            reader.Advance(value.Length);

            return value;
        }

        public static ReadOnlyMemory<T> Read<T>(this IBufferReader<T> reader, int count)
        {
            var value = reader.Memory[..count];

            reader.Advance(value.Length);

            return value;
        }

        public static T Read<T>(this IBufferReader<T> reader)
        {
            var valueSpan = reader.Memory.Span[..1];
            var value = valueSpan[0];

            reader.Advance(valueSpan.Length);

            return value;
        }
    }
}
