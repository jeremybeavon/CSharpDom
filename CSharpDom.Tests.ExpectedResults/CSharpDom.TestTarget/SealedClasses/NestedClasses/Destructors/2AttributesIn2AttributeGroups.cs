namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Destructors
{
    public sealed class SealedClassWithNestedClassWithDestructorWith2AttributesIn2AttributeGroups
    {
        public class Class
        {
            [Attribute1]
            [Attribute2]
            ~Class()
            {
            }
        }
    }
}
