namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedDelegates
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
