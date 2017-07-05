namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Events
{
    public static class StaticClassWithNestedPartialClassWithEventWith1Attribute
    {
        public partial class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
