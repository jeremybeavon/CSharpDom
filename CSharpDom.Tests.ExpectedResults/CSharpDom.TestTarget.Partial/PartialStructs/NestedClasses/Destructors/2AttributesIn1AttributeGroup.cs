namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Destructors
{
    public partial struct PartialStructWithNestedClassWithDestructorWith2AttributesIn1AttributeGroup
    {
        public class Class
        {
            [Attribute1, Attribute2]
            ~Class()
            {
            }
        }
    }
}
