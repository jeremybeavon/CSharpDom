namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedStructWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public struct NestedStruct
            {
            }
        }
    }
}
