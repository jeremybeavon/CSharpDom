namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events.EventProperties
{
    public class ClassWithNestedAbstractClassWithEventPropertyWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
