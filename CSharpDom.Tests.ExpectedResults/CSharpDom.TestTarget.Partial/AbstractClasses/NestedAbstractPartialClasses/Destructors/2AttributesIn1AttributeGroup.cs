namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Destructors
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithDestructorWith2AttributesIn1AttributeGroup
    {
        public abstract partial class Class
        {
            [Attribute1, Attribute2]
            ~Class()
            {
            }
        }
    }
}
