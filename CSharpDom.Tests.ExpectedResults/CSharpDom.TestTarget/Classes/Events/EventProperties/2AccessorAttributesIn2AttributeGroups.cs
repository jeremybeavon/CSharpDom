namespace CSharpDom.TestTarget.Classes.Events.EventProperties
{
    public class ClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
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
