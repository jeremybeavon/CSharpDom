namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Destructors
{
    public static class StaticClassWithNestedSealedPartialClassWithDestructorWith2AttributesIn2AttributeGroups
    {
        public sealed partial class Class
        {
            [Attribute1]
            [Attribute2]
            ~Class()
            {
            }
        }
    }
}
