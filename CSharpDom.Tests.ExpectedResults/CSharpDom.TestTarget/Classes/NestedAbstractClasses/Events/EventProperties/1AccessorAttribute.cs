namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events.EventProperties
{
    public class ClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute
    {
        public abstract class Class
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
}
