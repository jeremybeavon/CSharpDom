namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedDelegates
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
