namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedSealedClasses
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedSealedClassWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
