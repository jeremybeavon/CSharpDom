namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedSealedPartialClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class<T>
            where T : IInterface
        {
        }
    }
}
