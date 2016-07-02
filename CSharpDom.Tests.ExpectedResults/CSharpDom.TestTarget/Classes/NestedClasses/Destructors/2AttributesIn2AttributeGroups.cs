namespace CSharpDom.TestTarget.Classes.NestedClasses.Destructors
{
    public class ClassWithNestedClassWithDestructorWith2AttributesIn2AttributeGroups
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
