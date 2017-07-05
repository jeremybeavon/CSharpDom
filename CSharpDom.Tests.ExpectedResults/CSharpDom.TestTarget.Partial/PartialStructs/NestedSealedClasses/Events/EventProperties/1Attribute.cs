namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedSealedClassWithEventPropertyWith1Attribute
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
