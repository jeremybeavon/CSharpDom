namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedPartialClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
