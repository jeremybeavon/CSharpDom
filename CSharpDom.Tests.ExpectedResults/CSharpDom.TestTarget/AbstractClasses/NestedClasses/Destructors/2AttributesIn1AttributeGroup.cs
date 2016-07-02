namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Destructors
{
    public abstract class AbstractClassWithNestedClassWithDestructorWith2AttributesIn1AttributeGroup
    {
        public class Class
        {
            [Attribute1, Attribute2]
            ~Class()
            {
            }
        }
    }
}
