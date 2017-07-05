namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedDelegates
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
