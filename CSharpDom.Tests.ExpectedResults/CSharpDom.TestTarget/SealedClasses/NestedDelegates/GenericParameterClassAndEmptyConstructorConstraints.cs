namespace CSharpDom.TestTarget.SealedClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
            where T : class, new();
    }
}
