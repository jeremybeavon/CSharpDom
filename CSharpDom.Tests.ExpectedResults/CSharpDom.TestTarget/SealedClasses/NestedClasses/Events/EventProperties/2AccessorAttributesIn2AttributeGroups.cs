namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
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
