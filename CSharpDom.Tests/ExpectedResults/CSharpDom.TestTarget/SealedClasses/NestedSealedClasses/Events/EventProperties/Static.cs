namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedSealedClassWithStaticEventProperty
    {
        public sealed class Class
        {
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
