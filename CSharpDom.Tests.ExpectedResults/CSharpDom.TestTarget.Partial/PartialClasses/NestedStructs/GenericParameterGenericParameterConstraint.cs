namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs
{
    public partial class PartialClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public struct Struct<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
