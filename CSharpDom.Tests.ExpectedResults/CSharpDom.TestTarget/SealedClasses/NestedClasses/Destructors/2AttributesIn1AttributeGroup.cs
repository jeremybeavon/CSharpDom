namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Destructors
{
    public sealed class SealedClassWithNestedClassWithDestructorWith2AttributesIn1AttributeGroup
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
