namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}
