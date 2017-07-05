namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Destructors
{
    public sealed class SealedClassWithNestedSealedPartialClassWithDestructorWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            ~Class()
            {
            }
        }
    }
}
