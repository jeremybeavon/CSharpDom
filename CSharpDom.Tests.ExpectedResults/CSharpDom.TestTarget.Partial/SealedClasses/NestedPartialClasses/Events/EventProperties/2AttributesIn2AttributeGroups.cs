namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedPartialClassWithEventPropertyWith2AttributesIn2AttributeGroups
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
