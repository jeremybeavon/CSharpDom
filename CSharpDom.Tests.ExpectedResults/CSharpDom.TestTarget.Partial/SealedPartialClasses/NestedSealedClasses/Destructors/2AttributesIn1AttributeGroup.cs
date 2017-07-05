namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Destructors
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroup
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
