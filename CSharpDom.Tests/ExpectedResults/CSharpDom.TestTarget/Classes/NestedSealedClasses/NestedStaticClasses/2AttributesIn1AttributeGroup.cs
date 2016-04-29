namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedStaticClasses
{
    public class ClassWithNestedSealedClassWithNestedStaticClassWith2AttributesIn1AttributeGroup
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
