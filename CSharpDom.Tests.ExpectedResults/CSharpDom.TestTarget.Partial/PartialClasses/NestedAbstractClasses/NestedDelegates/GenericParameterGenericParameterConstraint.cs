namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedDelegates
{
    public partial class PartialClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
                where TKey : TValue;
        }
    }
}
