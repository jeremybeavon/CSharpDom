namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedDelegates
{
    public partial class PartialClassWithNestedSealedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
