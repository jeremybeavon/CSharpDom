namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedStructs
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedStructWith2AttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            [Attribute1, Attribute2]
            public struct NestedStruct
            {
            }
        }
    }
}
