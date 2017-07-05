namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Destructors
{
    public partial class PartialClassWithNestedSealedClassWithDestructorWith1Attribute
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
