namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public sealed partial class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
