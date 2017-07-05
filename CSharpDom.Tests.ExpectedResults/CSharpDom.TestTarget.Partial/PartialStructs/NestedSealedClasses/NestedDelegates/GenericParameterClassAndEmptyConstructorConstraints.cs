namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedDelegates
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
