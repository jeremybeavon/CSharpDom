namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.Events.EventProperties
{
    public partial class PartialClassWithNestedStaticClassWithEventPropertyWith1Attribute
    {
        public static class Class
        {
            [Attribute1]
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
