namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
