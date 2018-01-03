

namespace Kappa.Util
{
    public static class Option
    {
        public static IOption<T> Some<T>(T item)
        {
            return new Some<T>(item);
        }
        public static IOption<T> None<T>()
        {
            return new None<T>();
        }
    }
    public interface IOption<T>
    {
        T Item { get; }
        bool HasItem { get; }
    }

    public class Some<T> : IOption<T>
    {
        public T Item { get; }
        public bool HasItem { get; } = true;
        public Some(T item)
        {
            Item = item;
        }
    }

    public class None<T> : IOption<T>
    {
        public T Item { get; }
        public bool HasItem { get; } = false;
        public None()
        {
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Ref<T>
    {
        public T Item { get; } 
        public Ref( T item )
        {
            Item = item;
        }
    }
}
