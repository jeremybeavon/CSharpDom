namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public struct Struct<T>
            where T : BaseClass
        {
        }
    }
}
