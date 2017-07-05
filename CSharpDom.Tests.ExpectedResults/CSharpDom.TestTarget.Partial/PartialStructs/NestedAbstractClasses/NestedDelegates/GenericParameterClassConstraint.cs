namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedDelegates
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
