namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs
{
    public partial class PartialClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct<T>
            where T : new()
        {
        }
    }
}
