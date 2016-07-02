namespace CSharpDom.TestTarget.Classes.NestedClasses.Events
{
    public class ClassWithNestedClassWithOverrideEvent
    {
        public class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
