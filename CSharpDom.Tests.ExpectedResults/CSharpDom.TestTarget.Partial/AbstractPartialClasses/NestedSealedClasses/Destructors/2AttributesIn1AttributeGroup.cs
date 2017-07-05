namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Destructors
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            ~Class()
            {
            }
        }
    }
}
