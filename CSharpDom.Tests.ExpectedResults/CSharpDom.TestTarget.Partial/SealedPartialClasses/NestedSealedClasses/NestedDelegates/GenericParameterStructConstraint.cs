namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
