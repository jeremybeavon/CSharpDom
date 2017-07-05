namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Destructors
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithDestructorWith2AttributesIn1AttributeGroup
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
