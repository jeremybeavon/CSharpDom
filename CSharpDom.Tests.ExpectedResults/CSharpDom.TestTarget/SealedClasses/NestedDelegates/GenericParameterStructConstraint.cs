namespace CSharpDom.TestTarget.SealedClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public delegate void DelegateWithGenericParameterStructConstraint<T>()
            where T : struct;
    }
}
