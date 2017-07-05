namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Events
{
    public class ClassWithNestedPartialClassWithEventWith2AttributesIn2AttributeGroups
    {
        public partial class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
