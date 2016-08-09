namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events
{
    public sealed class SealedClassWithNestedSealedClassWithEventWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
