namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Destructors
{
    public partial struct PartialStructWithNestedSealedClassWithDestructorWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            ~Class()
            {
            }
        }
    }
}
