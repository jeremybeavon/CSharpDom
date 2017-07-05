namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedClasses
{
    public struct StructWithNestedSealedPartialClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class<T>
            where T : IInterface
        {
        }
    }
}
