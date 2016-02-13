namespace CSharpDom.TestTarget.Delegates
{
    public delegate void DelegateWithGenericParameterStructConstraint<T>()
        where T : struct;
}
