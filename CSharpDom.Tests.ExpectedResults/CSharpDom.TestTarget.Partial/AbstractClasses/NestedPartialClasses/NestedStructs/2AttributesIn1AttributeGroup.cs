namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedStructWith2AttributesIn1AttributeGroup
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
