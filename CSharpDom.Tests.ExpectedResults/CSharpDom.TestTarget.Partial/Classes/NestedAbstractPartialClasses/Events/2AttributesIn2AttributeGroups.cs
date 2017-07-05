namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Events
{
    public class ClassWithNestedAbstractPartialClassWithEventWith2AttributesIn2AttributeGroups
    {
        public abstract partial class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
