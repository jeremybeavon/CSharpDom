namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Destructors
{
    public struct StructWithNestedAbstractClassWithDestructorWith2AttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            [Attribute1]
            [Attribute2]
            ~Class()
            {
            }
        }
    }
}
