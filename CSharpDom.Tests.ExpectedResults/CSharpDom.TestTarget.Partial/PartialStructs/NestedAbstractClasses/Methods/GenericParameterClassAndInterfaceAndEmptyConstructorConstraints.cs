namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Methods
{
    public partial struct PartialStructWithWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public T Method<T>()
                where T : class, IInterface, new()
            {
                return default(T);
            }
        }
    }
}
