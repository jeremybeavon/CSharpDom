namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedPartialClassWithNestedPartialClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
