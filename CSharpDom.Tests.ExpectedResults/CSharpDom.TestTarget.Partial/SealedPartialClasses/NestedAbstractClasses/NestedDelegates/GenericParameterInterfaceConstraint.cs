namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
