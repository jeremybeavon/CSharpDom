namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses
{
    public partial struct PartialStructWithWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class<T>
            where T : IInterface
        {
        }
    }
}
