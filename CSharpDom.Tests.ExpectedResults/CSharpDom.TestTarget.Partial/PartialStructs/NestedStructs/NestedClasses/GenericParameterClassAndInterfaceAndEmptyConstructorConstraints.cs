namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedClasses
{
    public partial struct PartialStructWithWithNestedStructWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
