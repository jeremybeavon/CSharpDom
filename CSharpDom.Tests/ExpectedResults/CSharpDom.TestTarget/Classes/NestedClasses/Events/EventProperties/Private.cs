namespace CSharpDom.TestTarget.Classes.NestedClasses.Events.EventProperties
{
    public class ClassWithNestedClassWithPrivateEventProperty
    {
        public class Class
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
