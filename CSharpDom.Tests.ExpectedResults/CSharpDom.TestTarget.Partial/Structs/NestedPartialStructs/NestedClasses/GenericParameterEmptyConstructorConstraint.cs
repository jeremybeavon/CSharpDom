namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedClasses
{
    public struct StructWithNestedStructWithNestedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
