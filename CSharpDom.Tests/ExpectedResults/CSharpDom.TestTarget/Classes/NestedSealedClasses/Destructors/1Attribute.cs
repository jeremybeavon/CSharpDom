namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Destructors
{
    public class ClassWithNestedSealedClassWithDestructorWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            ~Class()
            {
            }
        }
    }
}
