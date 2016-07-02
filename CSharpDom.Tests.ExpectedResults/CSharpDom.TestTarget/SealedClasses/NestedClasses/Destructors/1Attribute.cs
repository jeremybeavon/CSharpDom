namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Destructors
{
    public sealed class SealedClassWithNestedClassWithDestructorWith1Attribute
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
