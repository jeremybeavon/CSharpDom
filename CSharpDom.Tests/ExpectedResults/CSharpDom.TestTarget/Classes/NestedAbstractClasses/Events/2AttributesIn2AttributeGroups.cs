namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Constructors
{
    public class ClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
