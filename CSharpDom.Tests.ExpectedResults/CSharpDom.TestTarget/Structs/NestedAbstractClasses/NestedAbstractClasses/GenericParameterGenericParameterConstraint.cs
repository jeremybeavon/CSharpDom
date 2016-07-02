namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedAbstractClasses
{
    public struct StructWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
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
