namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public delegate void DelegateWithGenericParameterStructConstraint<T>()
            where T : struct;
    }
}
