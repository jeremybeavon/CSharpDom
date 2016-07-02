namespace CSharpDom.TestTarget.Delegates
{
    public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
        where T : class, new();
}
