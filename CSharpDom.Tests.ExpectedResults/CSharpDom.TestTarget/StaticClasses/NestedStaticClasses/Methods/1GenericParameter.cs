namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Methods
{
    public static class StaticClassWithNestedStaticClassWithMethodWith1GenericParameter
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
