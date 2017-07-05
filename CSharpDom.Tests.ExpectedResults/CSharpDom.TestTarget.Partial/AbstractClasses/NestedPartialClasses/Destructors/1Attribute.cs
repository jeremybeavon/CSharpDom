namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Destructors
{
    public abstract class AbstractClassWithNestedPartialClassWithDestructorWith1Attribute
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
