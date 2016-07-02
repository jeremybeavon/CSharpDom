namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Destructors
{
    public struct StructWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroup
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
