namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Destructors
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithDestructorWith1Attribute
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
