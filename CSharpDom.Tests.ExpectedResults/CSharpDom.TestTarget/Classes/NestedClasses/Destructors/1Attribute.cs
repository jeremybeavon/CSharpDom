namespace CSharpDom.TestTarget.Classes.NestedClasses.Destructors
{
    public class ClassWithNestedClassWithDestructorWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            ~Class()
            {
            }
        }
    }
}
