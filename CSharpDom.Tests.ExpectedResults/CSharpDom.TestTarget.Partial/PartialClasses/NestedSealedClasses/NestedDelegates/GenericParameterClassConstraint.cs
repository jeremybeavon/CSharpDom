namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedDelegates
{
    public partial class PartialClassWithNestedSealedClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
