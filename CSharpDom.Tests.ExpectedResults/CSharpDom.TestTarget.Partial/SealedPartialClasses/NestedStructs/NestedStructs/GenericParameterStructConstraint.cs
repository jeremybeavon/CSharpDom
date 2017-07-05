namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedStructWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
