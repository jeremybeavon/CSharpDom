namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Events
{
    public partial struct PartialStructWithWithNestedSealedClassWithEventWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
