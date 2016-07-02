namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedAbstractClassWithNestedSealedClassWith2ImplementedInterfaces
    {
        public abstract class Class
        {
            public sealed class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
