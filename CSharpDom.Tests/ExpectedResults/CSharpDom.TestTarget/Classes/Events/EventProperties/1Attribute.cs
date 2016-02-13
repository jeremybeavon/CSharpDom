namespace CSharpDom.TestTarget.Classes.Events.EventProperties
{
    public class ClassWithEventPropertyWith1Attribute
    {
        [Attribute1]
        public event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
