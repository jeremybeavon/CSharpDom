namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Destructors
{
    public class ClassWithNestedPartialClassWithDestructorWith1Attribute
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
