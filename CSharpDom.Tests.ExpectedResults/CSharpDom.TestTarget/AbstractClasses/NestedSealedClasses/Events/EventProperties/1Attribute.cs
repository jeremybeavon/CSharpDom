namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedSealedClassWithEventPropertyWith1Attribute
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
