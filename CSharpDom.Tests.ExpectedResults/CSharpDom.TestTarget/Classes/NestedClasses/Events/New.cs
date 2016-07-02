namespace CSharpDom.TestTarget.Classes.NestedClasses.Events
{
    public class ClassWithNestedClassWithNewEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
