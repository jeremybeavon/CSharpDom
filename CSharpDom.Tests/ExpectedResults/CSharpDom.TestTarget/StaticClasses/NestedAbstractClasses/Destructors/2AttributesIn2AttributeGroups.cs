namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Destructors
{
    public static class StaticClassWithNestedAbstractClassWithDestructorWith2AttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            [Attribute1]
            [Attribute2]
            ~Class()
            {
            }
        }
    }
}
