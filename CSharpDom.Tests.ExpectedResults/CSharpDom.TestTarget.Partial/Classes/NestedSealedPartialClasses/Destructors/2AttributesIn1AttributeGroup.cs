namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Destructors
{
    public class ClassWithNestedSealedPartialClassWithDestructorWith2AttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            [Attribute1, Attribute2]
            ~Class()
            {
            }
        }
    }
}
