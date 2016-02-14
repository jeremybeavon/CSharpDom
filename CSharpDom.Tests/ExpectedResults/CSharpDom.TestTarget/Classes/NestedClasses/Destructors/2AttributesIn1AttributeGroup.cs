namespace CSharpDom.TestTarget.Classes.NestedClasses.Destructors
{
    public class ClassWithNestedClassWithDestructorWith2AttributesIn1AttributeGroup
    {
        public class Class
        {
            [Attribute1, Attribute2]
            ~Class()
            {
            }
        }
    }
}
