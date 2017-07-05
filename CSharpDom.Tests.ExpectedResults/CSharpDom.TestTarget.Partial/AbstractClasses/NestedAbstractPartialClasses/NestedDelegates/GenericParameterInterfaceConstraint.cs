namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public abstract partial class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
