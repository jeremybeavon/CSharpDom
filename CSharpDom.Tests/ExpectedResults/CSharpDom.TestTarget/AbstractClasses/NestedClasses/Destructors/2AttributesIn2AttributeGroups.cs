namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Destructors
{
    public abstract class AbstractClassWithNestedClassWithDestructorWith2AttributesIn2AttributeGroups
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
