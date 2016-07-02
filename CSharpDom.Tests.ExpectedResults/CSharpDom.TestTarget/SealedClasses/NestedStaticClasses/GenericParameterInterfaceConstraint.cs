namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public static class Class<T>
            where T : IInterface
        {
        }
    }
}
