namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Destructors
{
    public static class StaticClassWithNestedAbstractClassWithDestructorWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            ~Class()
            {
            }
        }
    }
}
