namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Destructors
{
    public static class StaticClassWithNestedSealedPartialClassWithDestructorWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            ~Class()
            {
            }
        }
    }
}
