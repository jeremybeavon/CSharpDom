namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Events
{
    public class ClassWithNestedPartialClassWithEventWith2AttributesIn1AttributeGroup
    {
        public partial class Class
        {
            [Attribute1, Attribute2]
            public event EventHandler Event;
        }
    }
}
