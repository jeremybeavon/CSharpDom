namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Destructors
{
    public class ClassWithNestedAbstractClassWithDestructorWith2AttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            [Attribute1]
            [Attribute2]
            ~Class()
            {
            }
        }
    }
}
