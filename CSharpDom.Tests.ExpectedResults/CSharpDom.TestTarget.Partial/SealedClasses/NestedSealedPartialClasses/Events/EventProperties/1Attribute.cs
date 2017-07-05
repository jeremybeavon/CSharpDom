namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedSealedPartialClassWithEventPropertyWith1Attribute
    {
        public sealed partial class Class
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
