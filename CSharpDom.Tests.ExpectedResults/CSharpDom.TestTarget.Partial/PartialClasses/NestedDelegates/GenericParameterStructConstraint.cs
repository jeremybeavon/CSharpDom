namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedDelegates
{
    public partial class PartialClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public delegate void DelegateWithGenericParameterStructConstraint<T>()
            where T : struct;
    }
}
