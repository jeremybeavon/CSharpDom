namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedSealedClasses
{
    public class ClassWithNestedSealedClassWithNestedSealedClassWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
