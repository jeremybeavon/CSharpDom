namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Destructors
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithDestructorWith1Attribute
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
