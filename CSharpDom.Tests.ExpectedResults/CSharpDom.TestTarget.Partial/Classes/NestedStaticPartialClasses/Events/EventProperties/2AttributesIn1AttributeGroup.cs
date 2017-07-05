namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.Events.EventProperties
{
    public class ClassWithNestedStaticPartialClassWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        public static partial class Class
        {
            [Attribute1, Attribute2]
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
