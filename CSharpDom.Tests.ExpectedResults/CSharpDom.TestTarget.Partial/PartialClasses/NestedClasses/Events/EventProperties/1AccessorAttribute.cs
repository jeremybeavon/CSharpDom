namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Events.EventProperties
{
    public partial class PartialClassWithNestedClassWithEventPropertyWith1AccessorAttribute
    {
        public class Class
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
