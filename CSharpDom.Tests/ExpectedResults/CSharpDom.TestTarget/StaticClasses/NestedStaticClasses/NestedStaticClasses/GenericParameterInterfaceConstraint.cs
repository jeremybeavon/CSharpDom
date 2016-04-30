namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
