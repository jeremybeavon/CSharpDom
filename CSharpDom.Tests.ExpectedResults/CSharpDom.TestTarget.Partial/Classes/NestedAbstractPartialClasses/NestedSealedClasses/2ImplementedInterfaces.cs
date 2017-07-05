namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedSealedClasses
{
    public class ClassWithNestedAbstractPartialClassWithNestedSealedPartialClassWith2ImplementedInterfaces
    {
        public abstract partial class Class
        {
            public sealed class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
