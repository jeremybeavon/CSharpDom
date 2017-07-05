namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Events.EventProperties
{
    public static class StaticClassWithNestedSealedPartialClassWithEventPropertyWith1Attribute
    {
        public sealed partial class Class
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
