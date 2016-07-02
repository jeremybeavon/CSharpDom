namespace CSharpDom.TestTarget.AbstractClasses.Constructors
{
    public abstract class AbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups
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
