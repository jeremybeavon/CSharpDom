namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Destructors
{
    public class ClassWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroup
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
