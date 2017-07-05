namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedStaticClasses
{
    public class ClassWithNestedSealedPartialClassWithNestedStaticPartialClassWith2AttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            [Attribute1, Attribute2]
            public static class NestedClass
            {
            }
        }
    }
}
