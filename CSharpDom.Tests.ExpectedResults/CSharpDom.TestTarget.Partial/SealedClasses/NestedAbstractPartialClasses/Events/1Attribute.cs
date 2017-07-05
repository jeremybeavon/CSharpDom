namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Events
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithEventWith1Attribute
    {
        public abstract partial class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
