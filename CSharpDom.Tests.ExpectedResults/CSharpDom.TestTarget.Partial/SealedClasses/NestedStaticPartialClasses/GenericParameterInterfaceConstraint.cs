namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStaticPartialClassWithGenericParameterInterfaceConstraint
    {
        public static class Class<T>
            where T : IInterface
        {
        }
    }
}
