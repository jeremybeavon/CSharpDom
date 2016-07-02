namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Methods
{
    public abstract class AbstractClassWithNestedSealedClassWithMethodWith1GenericParameter
    {
        public sealed class Class
        {
            public T Method<T>()
            {
                return default(T);
            }
        }
    }
}
