namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Destructors
{
    public static class StaticClassWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            ~Class()
            {
            }
        }
    }
}
