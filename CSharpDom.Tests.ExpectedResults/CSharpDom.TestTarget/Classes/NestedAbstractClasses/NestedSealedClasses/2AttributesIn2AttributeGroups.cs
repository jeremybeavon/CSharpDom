namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedSealedClasses
{
    public class ClassWithNestedAbstractClassWithNestedSealedClassWith2AttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            [Attribute1]
            [Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
