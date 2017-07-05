namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
