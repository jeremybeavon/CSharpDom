namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedStructs
{
    public struct StructWithNestedAbstractPartialClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public abstract partial class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
