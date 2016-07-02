namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedSealedClasses
{
    public class ClassWithNestedAbstractClassWithNestedSealedClassWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public sealed class NestedClass
            {
            }
        }
    }
}
