namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedStructs
{
    public partial class PartialClassWithNestedStructWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
