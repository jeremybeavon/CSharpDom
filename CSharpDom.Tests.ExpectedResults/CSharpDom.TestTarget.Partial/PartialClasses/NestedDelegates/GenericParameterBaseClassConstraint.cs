namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedDelegates
{
    public partial class PartialClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
            where T : BaseClass;
    }
}
