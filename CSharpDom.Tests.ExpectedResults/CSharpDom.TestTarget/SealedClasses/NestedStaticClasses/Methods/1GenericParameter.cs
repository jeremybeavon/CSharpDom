namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Methods
{
    public sealed class SealedClassWithNestedStaticClassWithMethodWith1GenericParameter
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
