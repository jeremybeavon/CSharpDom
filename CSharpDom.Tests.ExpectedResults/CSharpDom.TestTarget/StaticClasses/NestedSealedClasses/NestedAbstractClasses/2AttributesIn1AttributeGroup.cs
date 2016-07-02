namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedSealedClassWithNestedAbstractClassWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public abstract class NestedClass
            {
            }
        }
    }
}
