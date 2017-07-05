namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public abstract partial class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
