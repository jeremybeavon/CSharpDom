namespace CSharpDom.TestTarget.Delegates
{
    public delegate void DelegateWithGenericParameterClassConstraint<T>()
        where T : class;
}
