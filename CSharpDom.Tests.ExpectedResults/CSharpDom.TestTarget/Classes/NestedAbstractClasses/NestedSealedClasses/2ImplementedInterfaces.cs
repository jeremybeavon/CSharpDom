namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedSealedClasses
{
    public class ClassWithNestedAbstractClassWithNestedSealedClassWith2ImplementedInterfaces
    {
        public abstract class Class
        {
            public sealed class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
