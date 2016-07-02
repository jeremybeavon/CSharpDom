namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Destructors
{
    public static class StaticClassWithNestedSealedClassWithDestructorWith1Attribute
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
