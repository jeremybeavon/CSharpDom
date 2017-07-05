namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedClasses
{
    public struct StructWithNestedSealedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
