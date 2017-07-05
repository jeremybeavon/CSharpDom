namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedClassWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public class NestedClass
            {
            }
        }
    }
}
