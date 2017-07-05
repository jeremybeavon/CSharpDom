namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
