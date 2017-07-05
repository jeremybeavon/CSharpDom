namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedDelegates
{
    public partial class PartialClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public delegate void DelegateWithGenericParameterClassConstraint<T>()
            where T : class;
    }
}
