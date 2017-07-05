namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses
{
    public static partial class StaticPartialClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public static class Class<T>
            where T : IInterface
        {
        }
    }
}
