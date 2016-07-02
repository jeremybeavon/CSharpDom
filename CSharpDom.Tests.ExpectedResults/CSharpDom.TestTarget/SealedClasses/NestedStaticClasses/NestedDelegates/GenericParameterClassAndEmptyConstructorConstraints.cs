namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
