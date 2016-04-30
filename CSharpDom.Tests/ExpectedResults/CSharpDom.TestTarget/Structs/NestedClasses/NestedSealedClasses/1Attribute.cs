namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedSealedClasses
{
    public struct StructWithNestedClassWithNestedSealedClassWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            public sealed class NestedClass
            {
            }
        }
    }
}
