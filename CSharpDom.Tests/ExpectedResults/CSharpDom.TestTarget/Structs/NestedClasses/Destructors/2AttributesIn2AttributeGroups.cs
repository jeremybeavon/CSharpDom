namespace CSharpDom.TestTarget.Structs.NestedClasses.Destructors
{
    public struct StructWithNestedClassWithDestructorWith2AttributesIn2AttributeGroups
    {
        public class Class
        {
            [Attribute1]
            [Attribute2]
            ~Class()
            {
            }
        }
    }
}
