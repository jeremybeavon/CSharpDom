namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Events.EventProperties
{
    public static class StaticClassWithNestedPartialClassWithEventPropertyWith1Attribute
    {
        public partial class Class
        {
            [Attribute1]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
