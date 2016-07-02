namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        public class Class
        {
            [Attribute1, Attribute2]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
