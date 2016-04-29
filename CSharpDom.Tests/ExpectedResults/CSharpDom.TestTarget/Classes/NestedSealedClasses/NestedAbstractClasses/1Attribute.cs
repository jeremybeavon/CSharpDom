namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedAbstractClasses
{
    public class ClassWithNestedSealedClassWithNestedAbstractClassWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public abstract class NestedClass
            {
            }
        }
    }
}
