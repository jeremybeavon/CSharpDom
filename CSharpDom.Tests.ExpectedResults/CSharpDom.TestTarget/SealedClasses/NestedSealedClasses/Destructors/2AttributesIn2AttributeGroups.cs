namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Destructors
{
    public sealed class SealedClassWithNestedSealedClassWithDestructorWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            ~Class()
            {
            }
        }
    }
}
