namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs
{
    public partial class PartialClassWithNestedStructWithGenericParameterStructConstraint
    {
        public struct Struct<T>
            where T : struct
        {
        }
    }
}
