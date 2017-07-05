namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Methods
{
    public static class StaticClassWithNestedAbstractPartialClassWithMethodWith1GenericParameter
    {
        public abstract partial class Class
        {
            public T Method<T>()
            {
                return default(T);
            }
        }
    }
}
