namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedClasses
{
    public partial struct PartialStructWithNestedSealedClassWithNestedClassWith1Attribute
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
