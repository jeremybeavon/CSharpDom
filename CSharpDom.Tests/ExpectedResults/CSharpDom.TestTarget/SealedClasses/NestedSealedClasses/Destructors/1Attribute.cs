namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Destructors
{
    public sealed class SealedClassWithNestedSealedClassWithDestructorWith1Attribute
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
