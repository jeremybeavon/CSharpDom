namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
