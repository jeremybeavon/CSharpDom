namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
