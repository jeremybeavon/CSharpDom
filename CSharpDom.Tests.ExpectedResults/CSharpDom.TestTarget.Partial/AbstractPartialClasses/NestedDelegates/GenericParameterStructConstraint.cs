namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public delegate void DelegateWithGenericParameterStructConstraint<T>()
            where T : struct;
    }
}
