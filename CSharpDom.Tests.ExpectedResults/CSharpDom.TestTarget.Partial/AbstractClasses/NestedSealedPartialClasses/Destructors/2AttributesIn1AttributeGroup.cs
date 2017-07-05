namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Destructors
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithDestructorWith2AttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            [Attribute1, Attribute2]
            ~Class()
            {
            }
        }
    }
}
