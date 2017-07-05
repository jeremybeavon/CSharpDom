namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedStructWithGenericParameterStructConstraint
    {
        public struct Struct<T>
            where T : struct
        {
        }
    }
}
