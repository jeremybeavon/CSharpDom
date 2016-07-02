namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedSealedClassWith2AttributesIn1AttributeGroup
    {
        public static class Class
        {
            [Attribute1, Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
