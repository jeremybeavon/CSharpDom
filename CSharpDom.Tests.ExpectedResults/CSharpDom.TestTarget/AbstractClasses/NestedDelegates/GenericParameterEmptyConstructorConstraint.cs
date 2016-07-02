namespace CSharpDom.TestTarget.AbstractClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
            where T : new();
    }
}
