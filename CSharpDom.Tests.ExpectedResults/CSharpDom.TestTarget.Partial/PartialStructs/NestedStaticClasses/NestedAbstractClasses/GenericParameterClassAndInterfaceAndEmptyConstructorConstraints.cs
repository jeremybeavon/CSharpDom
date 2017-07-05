namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
