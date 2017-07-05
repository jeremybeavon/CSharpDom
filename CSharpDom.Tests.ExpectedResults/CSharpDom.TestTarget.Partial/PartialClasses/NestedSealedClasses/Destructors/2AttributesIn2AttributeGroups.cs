namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Destructors
{
    public partial class PartialClassWithNestedSealedClassWithDestructorWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            ~Class()
            {
            }
        }
    }
}
