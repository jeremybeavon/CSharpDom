namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Constructors
{
    public struct StructWithNestedSealedClassWithConstructorWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public Class()
            {
            }
        }
    }
}
