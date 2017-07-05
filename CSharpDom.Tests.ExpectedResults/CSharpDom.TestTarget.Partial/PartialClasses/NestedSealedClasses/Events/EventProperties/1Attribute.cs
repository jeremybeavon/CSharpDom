namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Events.EventProperties
{
    public partial class PartialClassWithNestedSealedClassWithEventPropertyWith1Attribute
    {
        public sealed class Class
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
