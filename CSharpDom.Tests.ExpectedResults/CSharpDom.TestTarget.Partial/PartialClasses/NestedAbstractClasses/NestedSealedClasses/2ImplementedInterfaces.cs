namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedSealedClasses
{
    public partial class PartialClassWithNestedAbstractClassWithNestedSealedClassWith2ImplementedInterfaces
    {
        public abstract class Class
        {
            public sealed class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
