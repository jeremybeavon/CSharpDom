namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedClasses
{
    public struct StructWithNestedSealedClassWithNestedClassWith2ImplementedInterfaces
    {
        public sealed class Class
        {
            public class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
