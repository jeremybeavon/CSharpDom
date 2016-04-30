namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedClasses
{
    public struct StructWithNestedSealedClassWithNestedClassWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public class NestedClass
            {
            }
        }
    }
}
