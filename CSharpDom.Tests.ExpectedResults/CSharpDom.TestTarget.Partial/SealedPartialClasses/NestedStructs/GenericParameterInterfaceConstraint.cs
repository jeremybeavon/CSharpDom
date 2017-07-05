namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public struct Struct<T>
            where T : IInterface
        {
        }
    }
}
