namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedPartialClassWithNestedStructWith2AttributesIn1AttributeGroup
    {
        public partial class Class
        {
            [Attribute1, Attribute2]
            public struct NestedStruct
            {
            }
        }
    }
}
