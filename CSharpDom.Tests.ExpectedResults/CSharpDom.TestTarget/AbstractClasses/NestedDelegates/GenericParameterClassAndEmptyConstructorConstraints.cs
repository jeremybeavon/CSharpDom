namespace CSharpDom.TestTarget.AbstractClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
            where T : class, new();
    }
}
