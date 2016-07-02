namespace CSharpDom.TestTarget.Classes.Events.EventProperties
{
    public class ClassWithEventPropertyWith1AccessorAttribute
    {
        public event EventHandler Event
        {
            [Attribute1]
            add { }
            [Attribute1]
            remove { }
        }
    }
}
