namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Events.EventProperties
{
    public class ClassWithNestedAbstractPartialClassWithEventPropertyWith1AccessorAttribute
    {
        public abstract partial class Class
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
