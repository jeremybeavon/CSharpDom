namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Events.EventProperties
{
    public static class StaticClassWithNestedPartialClassWithEventPropertyWith2AttributesIn2AttributeGroups
    {
        public partial class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
