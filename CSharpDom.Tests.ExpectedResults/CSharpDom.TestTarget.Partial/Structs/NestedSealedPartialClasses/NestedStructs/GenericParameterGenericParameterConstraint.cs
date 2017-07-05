namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedStructs
{
    public struct StructWithNestedSealedPartialClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public sealed partial class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
