namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Destructors
{
    public abstract class AbstractClassWithNestedClassWithDestructorWith1Attribute
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
