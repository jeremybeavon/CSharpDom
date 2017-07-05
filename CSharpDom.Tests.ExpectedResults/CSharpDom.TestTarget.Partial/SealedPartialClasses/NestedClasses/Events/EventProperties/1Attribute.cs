namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedClassWithEventPropertyWith1Attribute
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
