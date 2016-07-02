namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Destructors
{
    public struct StructWithNestedSealedClassWithDestructorWith2AttributesIn2AttributeGroups
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
