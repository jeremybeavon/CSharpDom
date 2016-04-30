namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Destructors
{
    public static class StaticClassWithNestedClassWithDestructorWith1Attribute
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
