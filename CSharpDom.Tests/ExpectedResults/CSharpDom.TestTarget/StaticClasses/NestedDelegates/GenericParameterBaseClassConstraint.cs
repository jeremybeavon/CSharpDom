namespace CSharpDom.TestTarget.StaticClasses.NestedDelegates
{
    public static class StaticClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
            where T : BaseClass;
    }
}
