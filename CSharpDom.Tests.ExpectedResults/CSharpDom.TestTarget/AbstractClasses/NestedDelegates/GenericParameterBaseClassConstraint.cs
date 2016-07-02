namespace CSharpDom.TestTarget.AbstractClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
            where T : BaseClass;
    }
}
