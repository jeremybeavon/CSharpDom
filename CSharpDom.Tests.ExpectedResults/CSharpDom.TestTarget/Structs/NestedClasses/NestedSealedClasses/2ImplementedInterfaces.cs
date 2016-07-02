namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedSealedClasses
{
    public struct StructWithNestedClassWithNestedSealedClassWith2ImplementedInterfaces
    {
        public class Class
        {
            public sealed class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
