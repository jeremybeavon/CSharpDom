namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedAbstractClassWith2AttributesIn1AttributeGroup
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
