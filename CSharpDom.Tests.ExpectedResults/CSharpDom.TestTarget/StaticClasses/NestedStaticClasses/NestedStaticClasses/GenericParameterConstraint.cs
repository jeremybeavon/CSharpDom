namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
