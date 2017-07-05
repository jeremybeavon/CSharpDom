namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.Events
{
    public class ClassWithNestedStaticPartialClassWithEventWith2AttributesIn2AttributeGroups
    {
        public static partial class Class
        {
            [Attribute1]
            [Attribute2]
            public static event EventHandler Event;
        }
    }
}
