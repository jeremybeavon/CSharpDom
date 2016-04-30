namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Destructors
{
    public struct StructWithNestedAbstractClassWithDestructorWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            ~Class()
            {
            }
        }
    }
}
