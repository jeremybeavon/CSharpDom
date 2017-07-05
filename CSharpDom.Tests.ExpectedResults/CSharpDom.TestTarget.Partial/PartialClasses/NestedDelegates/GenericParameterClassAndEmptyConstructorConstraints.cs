namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedDelegates
{
    public partial class PartialClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
            where T : class, new();
    }
}
