namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Events.EventProperties
{
    public class ClassWithNestedSealedPartialClassWithEventPropertyWith2AttributesIn2AttributeGroups
    {
        public sealed partial class Class
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
