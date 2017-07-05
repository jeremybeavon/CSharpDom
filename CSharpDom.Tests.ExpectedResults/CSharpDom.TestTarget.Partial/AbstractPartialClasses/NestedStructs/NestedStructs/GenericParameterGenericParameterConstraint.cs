namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedStructWithGenericParameterGenericParameterConstraint
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
