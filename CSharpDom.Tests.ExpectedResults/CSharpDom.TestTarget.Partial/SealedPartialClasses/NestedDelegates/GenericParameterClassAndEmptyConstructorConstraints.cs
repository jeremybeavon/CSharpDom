namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
            where T : class, new();
    }
}
