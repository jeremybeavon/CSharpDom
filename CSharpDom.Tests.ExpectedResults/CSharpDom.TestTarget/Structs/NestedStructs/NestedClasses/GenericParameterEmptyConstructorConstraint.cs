namespace CSharpDom.TestTarget.Structs.NestedStructs.NestedClasses
{
    public struct StructWithNestedStructWithNestedClassWithGenericParameterEmptyConstructorConstraint
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
