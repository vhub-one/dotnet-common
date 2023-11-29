
namespace Common.Buffers
{
    public readonly struct Chunk<T>
    {
        public T Data { get; }

        public int Index { get; }
        public bool IsFirst { get; }
        public bool IsLast { get; }

        public Chunk(T data, int index, bool isLast)
        {
            Data = data;
            Index = index;
            IsFirst = index == 0;
            IsLast = isLast;
        }
    }
}
