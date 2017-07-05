namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Events.EventProperties
{
    public class ClassWithNestedAbstractPartialClassWithEventPropertyWith1Attribute
    {
        public abstract partial class Class
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
