namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses
{
    public struct StructWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
