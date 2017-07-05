namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
