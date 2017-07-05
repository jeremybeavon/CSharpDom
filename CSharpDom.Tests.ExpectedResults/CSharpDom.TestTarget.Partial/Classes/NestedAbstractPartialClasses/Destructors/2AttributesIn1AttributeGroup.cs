namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Destructors
{
    public class ClassWithNestedAbstractPartialClassWithDestructorWith2AttributesIn1AttributeGroup
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
