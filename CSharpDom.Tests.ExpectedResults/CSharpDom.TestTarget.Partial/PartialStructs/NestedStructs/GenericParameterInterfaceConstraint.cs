namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs
{
    public partial struct PartialStructWithWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public struct Struct<T>
            where T : IInterface
        {
        }
    }
}
