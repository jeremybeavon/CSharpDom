namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Destructors
{
    public abstract class AbstractClassWithNestedAbstractClassWithDestructorWith1Attribute
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
