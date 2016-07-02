namespace CSharpDom.TestTarget.StaticClasses.NestedDelegates
{
    public static class StaticClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public delegate void DelegateWithGenericParameterClassConstraint<T>()
            where T : class;
    }
}
