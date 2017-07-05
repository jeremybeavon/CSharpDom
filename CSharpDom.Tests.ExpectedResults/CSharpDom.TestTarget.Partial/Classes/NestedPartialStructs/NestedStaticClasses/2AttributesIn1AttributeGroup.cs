namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedStaticClasses
{
    public class ClassWithNestedStructWithNestedStaticPartialClassWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public static class NestedClass
            {
            }
        }
    }
}
