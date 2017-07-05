namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
