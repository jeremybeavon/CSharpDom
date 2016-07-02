namespace CSharpDom.TestTarget.Delegates
{
    public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
        where T : IInterface;
}
