namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct<T>
            where T : new()
        {
        }
    }
}
