
namespace Common.Buffers
{
    public interface IBufferReader<T>
    {
        public ReadOnlyMemory<T> Memory { get; }
        void Advance(int count);
    }
}
