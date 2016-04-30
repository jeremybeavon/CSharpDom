namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public static class Class<T>
            where T : class
        {
        }
    }
}
