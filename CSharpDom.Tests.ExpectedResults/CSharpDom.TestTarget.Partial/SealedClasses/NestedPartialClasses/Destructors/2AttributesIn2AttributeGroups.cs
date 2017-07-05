namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Destructors
{
    public sealed class SealedClassWithNestedPartialClassWithDestructorWith2AttributesIn2AttributeGroups
    {
        public partial class Class
        {
            [Attribute1]
            [Attribute2]
            ~Class()
            {
            }
        }
    }
}
