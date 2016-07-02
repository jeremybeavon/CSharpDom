namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Destructors
{
    public sealed class SealedClassWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroup
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
