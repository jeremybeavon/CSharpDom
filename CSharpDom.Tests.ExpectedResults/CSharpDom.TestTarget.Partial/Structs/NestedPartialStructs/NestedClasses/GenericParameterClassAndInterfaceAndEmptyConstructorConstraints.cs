namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedClasses
{
    public struct StructWithNestedStructWithNestedPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
