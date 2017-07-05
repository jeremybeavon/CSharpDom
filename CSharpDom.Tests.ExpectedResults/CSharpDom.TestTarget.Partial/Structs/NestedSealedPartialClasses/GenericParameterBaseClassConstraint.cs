namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedClasses
{
    public struct StructWithNestedSealedPartialClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class<T>
            where T : BaseClass
        {
        }
    }
}
