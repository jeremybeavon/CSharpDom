namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedClassWith2ImplementedInterfaces
    {
        public sealed class Class
        {
            public class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
