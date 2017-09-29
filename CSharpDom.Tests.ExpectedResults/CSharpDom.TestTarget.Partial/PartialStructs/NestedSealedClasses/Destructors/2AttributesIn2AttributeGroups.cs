namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Destructors
{
    public partial struct PartialStructWithNestedSealedClassWithDestructorWith2AttributesIn2AttributeGroups
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
