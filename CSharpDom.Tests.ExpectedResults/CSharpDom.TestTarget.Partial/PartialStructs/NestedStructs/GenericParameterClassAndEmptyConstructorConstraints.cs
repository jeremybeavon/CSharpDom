namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs
{
    public partial struct PartialStructWithWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct<T>
            where T : class, new()
        {
        }
    }
}
