namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Destructors
{
    public static class StaticClassWithNestedAbstractClassWithDestructorWith1Attribute
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
