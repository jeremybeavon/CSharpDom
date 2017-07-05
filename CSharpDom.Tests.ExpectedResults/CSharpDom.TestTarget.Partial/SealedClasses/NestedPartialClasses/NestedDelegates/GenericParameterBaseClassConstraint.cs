namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedPartialClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public partial class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
