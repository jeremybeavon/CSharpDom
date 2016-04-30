namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedClassWith2ImplementedInterfaces
    {
        public sealed class Class
        {
            public class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
