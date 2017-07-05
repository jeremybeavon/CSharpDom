namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedAbstractClasses
{
    public class ClassWithNestedStructWithNestedAbstractPartialClassWith2AttributesIn1AttributeGroup
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
