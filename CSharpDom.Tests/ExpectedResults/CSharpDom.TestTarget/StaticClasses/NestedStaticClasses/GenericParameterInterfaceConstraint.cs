namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public static class Class<T>
            where T : IInterface
        {
        }
    }
}
