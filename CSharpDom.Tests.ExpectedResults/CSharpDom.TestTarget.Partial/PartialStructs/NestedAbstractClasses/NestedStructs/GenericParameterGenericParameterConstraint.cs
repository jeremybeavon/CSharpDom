namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedStructs
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
