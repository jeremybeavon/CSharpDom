namespace CSharpDom.TestTarget.Structs.NestedStructs
{
    public struct StructWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public struct Struct<T>
            where T : BaseClass
        {
        }
    }
}
