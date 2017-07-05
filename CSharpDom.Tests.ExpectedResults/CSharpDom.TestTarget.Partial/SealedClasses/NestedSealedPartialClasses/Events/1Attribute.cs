namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Events
{
    public sealed class SealedClassWithNestedSealedPartialClassWithEventWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
