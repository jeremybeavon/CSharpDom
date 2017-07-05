namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Events
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithEventWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
