namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedClassWithNestedSealedClassWith1Attribute
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
