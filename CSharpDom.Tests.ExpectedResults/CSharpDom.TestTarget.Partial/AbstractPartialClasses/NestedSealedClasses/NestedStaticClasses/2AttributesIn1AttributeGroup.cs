namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedStaticClasses
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedStaticClassWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public static class NestedClass
            {
            }
        }
    }
}
