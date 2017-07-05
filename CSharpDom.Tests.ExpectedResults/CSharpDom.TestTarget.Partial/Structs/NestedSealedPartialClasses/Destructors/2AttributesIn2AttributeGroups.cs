namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Destructors
{
    public struct StructWithNestedSealedPartialClassWithDestructorWith2AttributesIn2AttributeGroups
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
