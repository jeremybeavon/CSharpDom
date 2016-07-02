namespace CSharpDom.TestTarget.Classes.NestedClasses.Events.EventProperties
{
    public class ClassWithNestedClassWithOverrideEventProperty
    {
        public class Class : BaseClassWithEvent
        {
            public override event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
