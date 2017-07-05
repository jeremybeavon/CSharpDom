namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Destructors
{
    public struct StructWithNestedPartialClassWithDestructorWith2AttributesIn2AttributeGroups
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
