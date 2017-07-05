namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithMethodWith1GenericParameter
    {
        public static class Class
        {
            public static T Method<T>()
            {
                return default(T);
            }
        }
    }
}
