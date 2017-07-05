namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedStructs
{
    public struct StructWithNestedPartialClassWithNestedStructWith1Attribute
    {
        public partial class Class
        {
            [Attribute1]
            public struct NestedStruct
            {
            }
        }
    }
}
