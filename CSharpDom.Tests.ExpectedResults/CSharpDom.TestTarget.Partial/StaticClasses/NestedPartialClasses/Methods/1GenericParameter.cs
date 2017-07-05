namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Methods
{
    public static class StaticClassWithNestedPartialClassWithMethodWith1GenericParameter
    {
        public partial class Class
        {
            public T Method<T>()
            {
                return default(T);
            }
        }
    }
}
