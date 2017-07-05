namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedClasses
{
    public struct StructWithNestedSealedPartialClassWithGenericParameterClassConstraint
    {
        public sealed class Class<T>
            where T : class
        {
        }
    }
}
