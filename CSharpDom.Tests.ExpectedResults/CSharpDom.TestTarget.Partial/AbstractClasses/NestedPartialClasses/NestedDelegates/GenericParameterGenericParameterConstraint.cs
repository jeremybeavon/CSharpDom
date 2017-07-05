namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public partial class Class
        {
            public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
                where TKey : TValue;
        }
    }
}
