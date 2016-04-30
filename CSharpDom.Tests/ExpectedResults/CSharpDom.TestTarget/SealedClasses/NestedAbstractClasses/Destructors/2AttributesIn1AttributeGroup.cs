namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Destructors
{
    public sealed class SealedClassWithNestedAbstractClassWithDestructorWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            ~Class()
            {
            }
        }
    }
}
