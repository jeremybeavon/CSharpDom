namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.Methods
{
    public static class StaticClassWithNestedStaticPartialClassWithMethodWith1GenericParameter
    {
        public static partial class Class
        {
            public static T Method<T>()
            {
                return default(T);
            }
        }
    }
}
