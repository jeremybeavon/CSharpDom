namespace CSharpDom.TestTarget.Classes.NestedClasses.Events.EventProperties
{
    public class ClassWithNestedClassWithEventPropertyWithGenericDelegate
    {
        public class Class
        {
            public event EventHandler<EventArgs> Event
            {
                add { }
                remove { }
            }
        }
    }
}
