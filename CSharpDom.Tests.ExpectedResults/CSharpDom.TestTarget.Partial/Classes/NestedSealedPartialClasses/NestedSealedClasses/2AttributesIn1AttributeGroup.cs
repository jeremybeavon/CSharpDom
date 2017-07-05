namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedSealedClasses
{
    public class ClassWithNestedSealedPartialClassWithNestedSealedPartialClassWith2AttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            [Attribute1, Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
