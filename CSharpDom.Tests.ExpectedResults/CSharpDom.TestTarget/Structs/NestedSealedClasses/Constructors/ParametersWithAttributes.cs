namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Constructors
{
    public struct StructWithNestedSealedClassWithConstructorWithParametersWithAttributes
    {
        public sealed class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
