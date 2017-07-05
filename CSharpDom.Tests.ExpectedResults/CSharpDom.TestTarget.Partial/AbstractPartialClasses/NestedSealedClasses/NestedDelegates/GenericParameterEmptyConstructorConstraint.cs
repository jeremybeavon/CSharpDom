namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
