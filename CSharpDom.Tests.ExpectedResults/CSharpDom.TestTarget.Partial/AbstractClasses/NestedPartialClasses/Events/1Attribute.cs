namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Events
{
    public abstract class AbstractClassWithNestedPartialClassWithEventWith1Attribute
    {
        public partial class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
