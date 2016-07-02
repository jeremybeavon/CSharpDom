namespace CSharpDom.TestTarget.Structs.NestedStructs.NestedAbstractClasses
{
    public struct StructWithNestedStructWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
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
