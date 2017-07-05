namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Destructors
{
    public class ClassWithNestedPartialClassWithDestructorWith2AttributesIn1AttributeGroup
    {
        public partial class Class
        {
            [Attribute1, Attribute2]
            ~Class()
            {
            }
        }
    }
}
