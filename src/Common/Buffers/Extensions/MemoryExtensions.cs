
namespace Common.Buffers.Extensions
{
    public static class MemoryExtensions
    {
        public static IEnumerable<Chunk<Memory<T>>> Chunk<T>(this Memory<T> memory, int chunkSize)
        {
            for (var chunkOffset = 0; chunkOffset < memory.Length; chunkOffset += chunkSize)
            {
                var chunkLength = memory.Length - chunkOffset;
                var chunkLast = true;

                if (chunkLength > chunkSize)
                {
                    chunkLength = chunkSize;
                    chunkLast = false;
                }

                var chunk = memory.Slice(chunkOffset, chunkLength);

                yield return new Chunk<Memory<T>>(
                    chunk,
                    chunkOffset / chunkSize,
                    chunkLast
                );
            }
        }

        public static IEnumerable<Chunk<ReadOnlyMemory<T>>> Chunk<T>(this ReadOnlyMemory<T> memory, int chunkSize)
        {
            for (var chunkOffset = 0; chunkOffset < memory.Length; chunkOffset += chunkSize)
            {
                var chunkLength = memory.Length - chunkOffset;
                var chunkLast = true;

                if (chunkLength > chunkSize)
                {
                    chunkLength = chunkSize;
                    chunkLast = false;
                }

                var chunk = memory.Slice(chunkOffset, chunkLength);

                yield return new Chunk<ReadOnlyMemory<T>>(
                    chunk,
                    chunkOffset / chunkSize,
                    chunkLast
                );
            }
        }
    }
}
