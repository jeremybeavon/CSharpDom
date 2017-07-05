namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups
    {
        public class Class
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
