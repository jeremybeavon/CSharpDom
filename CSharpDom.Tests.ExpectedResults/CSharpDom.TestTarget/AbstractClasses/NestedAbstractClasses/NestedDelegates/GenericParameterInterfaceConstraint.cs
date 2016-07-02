namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
