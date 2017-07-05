namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
