namespace CSharpDom.TestTarget.AbstractClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public delegate void DelegateWithGenericParameterClassConstraint<T>()
            where T : class;
    }
}
