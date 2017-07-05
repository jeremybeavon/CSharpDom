namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedStaticPartialClassWithGenericParameterInterfaceConstraint
    {
        public static class Class<T>
            where T : IInterface
        {
        }
    }
}
