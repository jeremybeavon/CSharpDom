namespace CSharpDom.TestTarget.Classes.Events.EventProperties
{
    public class ClassWithEventPropertyWith2AttributesIn2AttributeGroups
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
