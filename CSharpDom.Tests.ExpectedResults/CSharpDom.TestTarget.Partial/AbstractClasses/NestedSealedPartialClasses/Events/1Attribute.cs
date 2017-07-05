namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Events
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithEventWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
