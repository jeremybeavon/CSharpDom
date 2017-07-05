namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedDelegates
{
    public partial class PartialClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
