namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedClasses
{
    public struct StructWithNestedAbstractPartialClassWithNestedPartialClassWith2AttributesIn1AttributeGroup
    {
        public abstract partial class Class
        {
            [Attribute1, Attribute2]
            public class NestedClass
            {
            }
        }
    }
}
