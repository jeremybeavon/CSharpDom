namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedClasses
{
    public class ClassWithNestedSealedClassWithNestedClassWith2AttributesIn1AttributeGroup
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
