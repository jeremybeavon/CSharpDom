namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Destructors
{
    public abstract class AbstractClassWithNestedAbstractClassWithDestructorWith2AttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            [Attribute1]
            [Attribute2]
            ~Class()
            {
            }
        }
    }
}
