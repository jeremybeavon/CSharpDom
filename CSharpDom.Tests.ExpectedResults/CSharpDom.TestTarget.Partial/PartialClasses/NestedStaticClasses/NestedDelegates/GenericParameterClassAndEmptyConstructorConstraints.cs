namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedDelegates
{
    public partial class PartialClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
