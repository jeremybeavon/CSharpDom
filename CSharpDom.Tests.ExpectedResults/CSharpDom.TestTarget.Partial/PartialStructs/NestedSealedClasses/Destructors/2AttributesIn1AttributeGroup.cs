namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Destructors
{
    public partial struct PartialStructWithWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroup
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
