namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Events.EventProperties
{
    public partial class PartialClassWithNestedClassWithEventPropertyWith1Attribute
    {
        public class Class
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
