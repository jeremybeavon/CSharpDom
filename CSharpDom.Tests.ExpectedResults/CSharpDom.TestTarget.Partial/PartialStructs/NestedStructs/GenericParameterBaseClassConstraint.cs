namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs
{
    public partial struct PartialStructWithWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public struct Struct<T>
            where T : BaseClass
        {
        }
    }
}
