namespace CSharpDom.TestTarget.Delegates
{
    public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
        where T : BaseClass;
}
