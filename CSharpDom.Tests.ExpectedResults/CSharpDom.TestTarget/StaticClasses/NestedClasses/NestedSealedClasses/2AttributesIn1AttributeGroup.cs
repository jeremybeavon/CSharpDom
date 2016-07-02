namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedClassWithNestedSealedClassWith2AttributesIn1AttributeGroup
    {
        public class Class
        {
            [Attribute1, Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
