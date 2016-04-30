namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedDelegates
{
    public static class StaticClassWithNestedSealedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
