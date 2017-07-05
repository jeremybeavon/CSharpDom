namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Destructors
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithDestructorWith2AttributesIn2AttributeGroups
    {
        public abstract partial class Class
        {
            [Attribute1]
            [Attribute2]
            ~Class()
            {
            }
        }
    }
}
