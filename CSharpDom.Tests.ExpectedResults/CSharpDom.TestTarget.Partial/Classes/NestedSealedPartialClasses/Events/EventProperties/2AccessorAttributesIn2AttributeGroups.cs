namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Events.EventProperties
{
    public class ClassWithNestedSealedPartialClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
    {
        public sealed partial class Class
        {
            public event EventHandler Event
            {
                [Attribute1]
                [Attribute2]
                add { }
                [Attribute1]
                [Attribute2]
                remove { }
            }
        }
    }
}
