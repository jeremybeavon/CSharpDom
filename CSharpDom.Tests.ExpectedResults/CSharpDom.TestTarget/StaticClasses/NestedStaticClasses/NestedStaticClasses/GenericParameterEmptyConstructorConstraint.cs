namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
