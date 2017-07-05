namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractClasses
{
    public struct StructWithNestedAbstractPartialClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
