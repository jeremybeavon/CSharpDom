namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedSealedClasses
{
    public partial struct PartialStructWithNestedClassWithNestedSealedClassWith1Attribute
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
