namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedAbstractPartialClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
