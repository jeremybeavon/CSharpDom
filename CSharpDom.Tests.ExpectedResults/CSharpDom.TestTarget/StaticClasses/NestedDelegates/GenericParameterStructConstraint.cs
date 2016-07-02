namespace CSharpDom.TestTarget.StaticClasses.NestedDelegates
{
    public static class StaticClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public delegate void DelegateWithGenericParameterStructConstraint<T>()
            where T : struct;
    }
}
