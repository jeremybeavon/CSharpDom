namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Destructors
{
    public static class StaticClassWithNestedPartialClassWithDestructorWith2AttributesIn1AttributeGroup
    {
        public partial class Class
        {
            [Attribute1, Attribute2]
            ~Class()
            {
            }
        }
    }
}
