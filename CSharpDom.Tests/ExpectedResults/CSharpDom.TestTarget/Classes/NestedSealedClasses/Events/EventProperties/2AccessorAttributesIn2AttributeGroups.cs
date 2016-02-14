namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Constructors
{
    public class ClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            public event EventHandler Event
            {
                [Attribute1]
                [Attribute2]
                add { }
                [Attribute1]
                [Attribute2]
                remove { }
            }
        }
    }
}
