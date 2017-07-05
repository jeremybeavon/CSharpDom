namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
    {
        public sealed class Class
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
