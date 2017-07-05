namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.Methods
{
    public partial class PartialClassWithNestedStaticClassWithMethodWith1GenericParameter
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
