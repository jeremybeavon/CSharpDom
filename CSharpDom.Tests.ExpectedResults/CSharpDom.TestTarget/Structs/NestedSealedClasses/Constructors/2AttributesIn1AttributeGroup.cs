namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Constructors
{
    public struct StructWithNestedSealedClassWithConstructorWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public Class()
            {
            }
        }
    }
}
