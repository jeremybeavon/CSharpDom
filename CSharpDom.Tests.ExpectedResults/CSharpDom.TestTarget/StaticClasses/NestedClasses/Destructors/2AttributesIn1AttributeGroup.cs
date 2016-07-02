namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Destructors
{
    public static class StaticClassWithNestedClassWithDestructorWith2AttributesIn1AttributeGroup
    {
        public class Class
        {
            [Attribute1, Attribute2]
            ~Class()
            {
            }
        }
    }
}
