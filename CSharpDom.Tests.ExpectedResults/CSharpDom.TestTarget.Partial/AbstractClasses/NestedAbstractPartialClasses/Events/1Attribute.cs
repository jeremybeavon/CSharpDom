namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Events
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithEventWith1Attribute
    {
        public abstract partial class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
