namespace CSharpDom.TestTarget.SealedClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
            where T : IInterface;
    }
}
