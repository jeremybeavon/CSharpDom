namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Destructors
{
    public sealed class SealedClassWithNestedPartialClassWithDestructorWith1Attribute
    {
        public partial class Class
        {
            [Attribute1]
            ~Class()
            {
            }
        }
    }
}
