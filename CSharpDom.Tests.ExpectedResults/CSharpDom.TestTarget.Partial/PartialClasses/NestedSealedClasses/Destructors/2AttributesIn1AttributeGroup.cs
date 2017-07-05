namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Destructors
{
    public partial class PartialClassWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroup
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
