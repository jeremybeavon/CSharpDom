namespace CSharpDom.TestTarget.AbstractClasses.Methods
{
    public abstract class AbstractClassWithMethodWith1GenericParameter
    {
        public T Method<T>()
        {
            return default(T);
        }
    }
}
