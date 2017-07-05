namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Destructors
{
    public class ClassWithNestedSealedPartialClassWithDestructorWith1Attribute
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
