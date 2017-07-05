namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public abstract partial class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
