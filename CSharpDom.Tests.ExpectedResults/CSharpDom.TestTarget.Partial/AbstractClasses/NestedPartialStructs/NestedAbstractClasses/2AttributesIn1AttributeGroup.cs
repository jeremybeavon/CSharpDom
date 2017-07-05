namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedAbstractPartialClassWith2AttributesIn1AttributeGroup
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
