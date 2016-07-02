namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Methods
{
    public static class StaticClassWithNestedSealedClassWithMethodWith1GenericParameter
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
