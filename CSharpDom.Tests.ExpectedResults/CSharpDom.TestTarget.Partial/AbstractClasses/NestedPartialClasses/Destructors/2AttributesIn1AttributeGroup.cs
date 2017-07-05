namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Destructors
{
    public abstract class AbstractClassWithNestedPartialClassWithDestructorWith2AttributesIn1AttributeGroup
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
