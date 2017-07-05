namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedClassWithEventPropertyWith1Attribute
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
