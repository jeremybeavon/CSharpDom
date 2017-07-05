namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Destructors
{
    public static class StaticClassWithNestedAbstractPartialClassWithDestructorWith2AttributesIn1AttributeGroup
    {
        public abstract partial class Class
        {
            [Attribute1, Attribute2]
            ~Class()
            {
            }
        }
    }
}
