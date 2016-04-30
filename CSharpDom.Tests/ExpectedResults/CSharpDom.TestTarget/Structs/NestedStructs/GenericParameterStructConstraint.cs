namespace CSharpDom.TestTarget.Structs.NestedStructs
{
    public struct StructWithNestedStructWithGenericParameterStructConstraint
    {
        public struct Struct<T>
            where T : struct
        {
        }
    }
}
