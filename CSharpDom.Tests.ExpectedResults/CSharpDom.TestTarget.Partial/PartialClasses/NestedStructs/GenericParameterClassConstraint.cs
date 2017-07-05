namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs
{
    public partial class PartialClassWithNestedStructWithGenericParameterClassConstraint
    {
        public struct Struct<T>
            where T : class
        {
        }
    }
}
