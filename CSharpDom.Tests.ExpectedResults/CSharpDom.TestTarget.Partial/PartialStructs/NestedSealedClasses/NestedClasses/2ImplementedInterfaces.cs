namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedClasses
{
    public partial struct PartialStructWithNestedSealedClassWithNestedClassWith2ImplementedInterfaces
    {
        public sealed class Class
        {
            public class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
