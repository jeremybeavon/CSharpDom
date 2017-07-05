namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedPartialClassWith2AttributesIn1AttributeGroup
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
