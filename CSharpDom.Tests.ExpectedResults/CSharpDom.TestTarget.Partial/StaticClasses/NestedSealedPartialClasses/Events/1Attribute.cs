namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Events
{
    public static class StaticClassWithNestedSealedPartialClassWithEventWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
