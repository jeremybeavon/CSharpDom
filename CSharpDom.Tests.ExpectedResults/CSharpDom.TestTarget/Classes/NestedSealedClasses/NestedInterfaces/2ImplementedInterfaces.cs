namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedInterfaces
{
    public class ClassWithNestedSealedClassWithNestedInterfaceWith2ImplementedInterfaces
    {
        public sealed class Class
        {
            public interface Interface : IInterface1, IInterface2
            {
            }
        }
    }
}
