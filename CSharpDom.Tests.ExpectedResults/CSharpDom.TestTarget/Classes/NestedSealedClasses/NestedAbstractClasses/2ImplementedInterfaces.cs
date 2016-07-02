namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedAbstractClasses
{
    public class ClassWithNestedSealedClassWithNestedAbstractClassWith2ImplementedInterfaces
    {
        public sealed class Class
        {
            public abstract class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
