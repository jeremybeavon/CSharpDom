namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Events
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithEventWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
