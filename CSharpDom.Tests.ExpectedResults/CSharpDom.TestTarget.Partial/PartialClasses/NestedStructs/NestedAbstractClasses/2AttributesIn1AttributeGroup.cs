namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedAbstractClasses
{
    public partial class PartialClassWithNestedStructWithNestedAbstractClassWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public abstract class NestedClass
            {
            }
        }
    }
}
