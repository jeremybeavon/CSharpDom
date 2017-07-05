namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithEventPropertyWith2AttributesIn2AttributeGroups
    {
        public static partial class Class
        {
            [Attribute1]
            [Attribute2]
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
