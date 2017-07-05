namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedInterfaceWith2ImplementedInterfaces
    {
        public sealed partial class Class
        {
            public interface Interface : IInterface1, IInterface2
            {
            }
        }
    }
}
