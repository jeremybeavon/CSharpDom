namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
