namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedStructWith2ImplementedInterfaces
    {
        public sealed class Class
        {
            public struct NestedStruct : IInterface1, IInterface2
            {
            }
        }
    }
}
