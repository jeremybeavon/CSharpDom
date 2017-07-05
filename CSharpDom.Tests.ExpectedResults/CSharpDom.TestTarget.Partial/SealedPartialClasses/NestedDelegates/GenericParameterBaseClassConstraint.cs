namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
            where T : BaseClass;
    }
}
