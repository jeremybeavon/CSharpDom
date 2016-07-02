namespace CSharpDom.TestTarget.Structs.NestedStructs.NestedClasses
{
    public struct StructWithNestedStructWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
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
