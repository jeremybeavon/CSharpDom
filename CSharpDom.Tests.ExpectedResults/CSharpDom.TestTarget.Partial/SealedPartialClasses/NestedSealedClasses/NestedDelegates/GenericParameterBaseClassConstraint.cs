namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
