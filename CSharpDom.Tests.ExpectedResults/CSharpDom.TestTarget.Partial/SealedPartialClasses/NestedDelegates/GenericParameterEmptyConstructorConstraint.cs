namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
            where T : new();
    }
}
