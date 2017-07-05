namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Events
{
    public sealed class SealedClassWithNestedPartialClassWithEventWith1Attribute
    {
        public partial class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
