namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class<T>
            where T : IInterface
        {
        }
    }
}
