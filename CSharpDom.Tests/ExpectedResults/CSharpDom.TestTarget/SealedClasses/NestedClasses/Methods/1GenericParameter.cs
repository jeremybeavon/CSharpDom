namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Methods
{
    public sealed class SealedClassWithNestedClassWithMethodWith1GenericParameter
    {
        public class Class
        {
            public T Method<T>()
            {
                return default(T);
            }
        }
    }
}
