namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedAbstractClasses
{
    public class ClassWithNestedSealedClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public abstract class NestedClass
            {
            }
        }
    }
}
