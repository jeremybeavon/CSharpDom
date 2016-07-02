namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Events.EventProperties
{
    public static class StaticClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups
    {
        public class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
