namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedDelegates
{
    public partial class PartialClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
            where T : new();
    }
}
