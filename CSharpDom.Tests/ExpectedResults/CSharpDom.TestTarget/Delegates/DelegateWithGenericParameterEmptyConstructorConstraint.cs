namespace CSharpDom.TestTarget.Delegates
{
    public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
        where T : new();
}
