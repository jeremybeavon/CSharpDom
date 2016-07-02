namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedClasses
{
    public static class StaticClassWithNestedSealedClassWithNestedClassWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public class NestedClass
            {
            }
        }
    }
}
