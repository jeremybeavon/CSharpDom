namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedPartialClassWith2ImplementedInterfaces
    {
        public sealed partial class Class
        {
            public class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
