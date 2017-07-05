namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedStructs
{
    public partial class PartialClassWithNestedStructWithNestedStructWithGenericParameterInterfaceConstraint
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
