namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedAbstractClasses
{
    public struct StructWithNestedStructWithNestedAbstractPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
