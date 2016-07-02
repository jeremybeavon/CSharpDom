namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedDelegates
{
    public static class StaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
