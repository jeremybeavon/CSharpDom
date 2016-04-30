namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedDelegates
{
    public static class StaticClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
