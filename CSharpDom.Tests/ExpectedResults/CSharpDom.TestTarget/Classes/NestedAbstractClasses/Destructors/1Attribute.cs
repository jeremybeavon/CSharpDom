namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Destructors
{
    public class ClassWithNestedAbstractClassWithDestructorWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            ~Class()
            {
            }
        }
    }
}
