namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedSealedClassWithPrivateEventProperty
    {
        public sealed class Class
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
