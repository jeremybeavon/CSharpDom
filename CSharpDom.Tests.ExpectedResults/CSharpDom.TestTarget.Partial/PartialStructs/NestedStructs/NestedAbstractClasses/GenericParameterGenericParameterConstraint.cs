namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedStructWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
