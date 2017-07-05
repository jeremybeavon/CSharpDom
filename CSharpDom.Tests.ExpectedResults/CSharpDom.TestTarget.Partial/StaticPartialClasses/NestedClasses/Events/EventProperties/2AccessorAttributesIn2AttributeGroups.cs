namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
    {
        public class Class
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
