namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedSealedClasses
{
    public class ClassWithNestedClassWithNestedSealedClassWith2AttributesIn1AttributeGroup
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
