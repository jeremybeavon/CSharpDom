namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.Methods
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithMethodWith1GenericParameter
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
