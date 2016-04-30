namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Destructors
{
    public abstract class AbstractClassWithNestedSealedClassWithDestructorWith1Attribute
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
