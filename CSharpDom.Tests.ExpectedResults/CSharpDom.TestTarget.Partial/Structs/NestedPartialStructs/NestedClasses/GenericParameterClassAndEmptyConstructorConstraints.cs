namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedClasses
{
    public struct StructWithNestedStructWithNestedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
