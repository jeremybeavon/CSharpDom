namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
