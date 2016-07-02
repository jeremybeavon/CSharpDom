namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
