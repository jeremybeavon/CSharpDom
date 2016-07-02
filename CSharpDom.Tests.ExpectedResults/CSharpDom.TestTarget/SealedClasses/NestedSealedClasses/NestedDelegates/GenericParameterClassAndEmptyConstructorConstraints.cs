namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedSealedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
