namespace CSharpDom.TestTarget.Classes.NestedClasses.Events
{
    public class ClassWithNestedClassWithNewStaticEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
