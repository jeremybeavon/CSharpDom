namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Destructors
{
    public sealed class SealedClassWithNestedAbstractClassWithDestructorWith2AttributesIn2AttributeGroups
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
