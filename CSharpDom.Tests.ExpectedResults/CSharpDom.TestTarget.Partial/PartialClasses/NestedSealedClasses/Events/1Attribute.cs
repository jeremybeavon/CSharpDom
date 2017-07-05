namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Events
{
    public partial class PartialClassWithNestedSealedClassWithEventWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
