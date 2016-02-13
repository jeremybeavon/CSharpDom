namespace CSharpDom.TestTarget.Classes.Destructors
{
    public class ClassWithDestructorWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        ~ClassWithDestructorWith2AttributesIn1AttributeGroup()
        {
        }
    }
}
