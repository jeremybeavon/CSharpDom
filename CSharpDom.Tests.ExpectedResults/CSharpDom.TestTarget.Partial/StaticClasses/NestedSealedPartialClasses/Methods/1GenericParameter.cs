namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Methods
{
    public static class StaticClassWithNestedSealedPartialClassWithMethodWith1GenericParameter
    {
        public sealed partial class Class
        {
            public T Method<T>()
            {
                return default(T);
            }
        }
    }
}
