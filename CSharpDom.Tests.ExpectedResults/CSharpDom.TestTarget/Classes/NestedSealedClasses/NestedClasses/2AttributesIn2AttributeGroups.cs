namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedClasses
{
    public class ClassWithNestedSealedClassWithNestedClassWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public class NestedClass
            {
            }
        }
    }
}
