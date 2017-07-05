namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedEnums
{
    public class ClassWithNestedSealedPartialClassWithNestedEnumWith2AttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            [Attribute1, Attribute2]
            public enum Enum
            {
            }
        }
    }
}
