namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs
{
    public partial struct PartialStructWithWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public struct Struct<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
