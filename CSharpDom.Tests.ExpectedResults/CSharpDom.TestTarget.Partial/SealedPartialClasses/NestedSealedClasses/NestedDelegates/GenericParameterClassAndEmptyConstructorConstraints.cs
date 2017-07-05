namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
