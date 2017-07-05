namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedDelegates
{
    public partial class PartialClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
