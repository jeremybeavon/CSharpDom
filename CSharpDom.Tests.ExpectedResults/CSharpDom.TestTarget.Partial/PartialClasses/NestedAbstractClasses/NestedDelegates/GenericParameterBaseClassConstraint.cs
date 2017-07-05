namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedDelegates
{
    public partial class PartialClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
