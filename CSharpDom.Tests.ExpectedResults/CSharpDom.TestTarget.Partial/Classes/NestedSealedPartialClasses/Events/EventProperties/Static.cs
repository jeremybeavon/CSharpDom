namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Events.EventProperties
{
    public class ClassWithNestedSealedPartialClassWithStaticEventProperty
    {
        public sealed partial class Class
        {
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
