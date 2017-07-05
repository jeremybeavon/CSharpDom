namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public struct Struct<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
