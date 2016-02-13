namespace CSharpDom.TestTarget.Classes.Events
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
