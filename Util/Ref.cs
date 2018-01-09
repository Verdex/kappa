
namespace Kappa.Util
{
    public class Ref<T>
    {
        public T Value { get; } 
        public Ref( T value )
        {
            Value = value;
        }
    }
}
