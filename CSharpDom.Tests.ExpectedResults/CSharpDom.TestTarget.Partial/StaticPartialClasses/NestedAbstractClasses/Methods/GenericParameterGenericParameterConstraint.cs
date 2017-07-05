namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Methods
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public Dictionary<TKey, TValue> Method<TKey, TValue>()
                where TValue : TKey
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
