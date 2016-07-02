namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.Constructors
{
    public sealed class SealedClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups
    {
        public struct Struct
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
