namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedEnums
{
    public class ClassWithNestedSealedClassWithNestedEnumWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public enum Enum
            {
            }
        }
    }
}
