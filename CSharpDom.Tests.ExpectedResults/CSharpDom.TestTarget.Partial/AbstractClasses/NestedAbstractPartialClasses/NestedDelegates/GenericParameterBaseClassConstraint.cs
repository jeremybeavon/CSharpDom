namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public abstract partial class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
