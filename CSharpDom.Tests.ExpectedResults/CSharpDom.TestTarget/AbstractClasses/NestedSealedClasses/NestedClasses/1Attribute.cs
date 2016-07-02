namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedClassWith1Attribute
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
