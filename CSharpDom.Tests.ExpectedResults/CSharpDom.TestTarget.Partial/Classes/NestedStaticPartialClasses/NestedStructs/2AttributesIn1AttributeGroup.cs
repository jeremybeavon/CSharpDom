namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedStructs
{
    public class ClassWithNestedStaticPartialClassWithNestedStructWith2AttributesIn1AttributeGroup
    {
        public static partial class Class
        {
            [Attribute1, Attribute2]
            public struct NestedStruct
            {
            }
        }
    }
}
