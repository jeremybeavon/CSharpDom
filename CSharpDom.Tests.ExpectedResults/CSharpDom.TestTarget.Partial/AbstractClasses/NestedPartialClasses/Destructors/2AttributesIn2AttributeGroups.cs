namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Destructors
{
    public abstract class AbstractClassWithNestedPartialClassWithDestructorWith2AttributesIn2AttributeGroups
    {
        public partial class Class
        {
            [Attribute1]
            [Attribute2]
            ~Class()
            {
            }
        }
    }
}
