namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Destructors
{
    public partial struct PartialStructWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            ~Class()
            {
            }
        }
    }
}
