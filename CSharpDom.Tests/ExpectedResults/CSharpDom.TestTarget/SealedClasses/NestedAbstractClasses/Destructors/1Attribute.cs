namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Destructors
{
    public sealed class SealedClassWithNestedAbstractClassWithDestructorWith1Attribute
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
