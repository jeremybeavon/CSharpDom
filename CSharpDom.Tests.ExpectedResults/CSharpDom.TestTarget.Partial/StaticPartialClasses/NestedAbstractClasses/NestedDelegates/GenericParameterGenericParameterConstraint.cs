namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
                where TKey : TValue;
        }
    }
}
