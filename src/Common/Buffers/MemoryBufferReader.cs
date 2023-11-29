
namespace Common.Buffers
{
    public class MemoryBufferReader<T> : IBufferReader<T>
    {
        private ReadOnlyMemory<T> _data;

        public MemoryBufferReader(ReadOnlyMemory<T> data)
        {
            _data = data;
        }

        public ReadOnlyMemory<T> Memory
        {
            get { return _data; }
        }

        public void Advance(int count)
        {
            _data = _data[count..];
        }
    }

    public static class MemoryBufferReader
    {
        public static MemoryBufferReader<T> Create<T>(ReadOnlyMemory<T> data)
        {
            return new MemoryBufferReader<T>(data);
        }

        public static MemoryBufferReader<T> Create<T>(T[] data)
        {
            return new MemoryBufferReader<T>(data);
        }
    }
}