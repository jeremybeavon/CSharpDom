namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedAbstractClasses
{
    public struct StructWithNestedStructWithNestedAbstractPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
