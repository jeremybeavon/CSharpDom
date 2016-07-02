namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedSealedClasses
{
    public class ClassWithNestedStructWithNestedSealedClassWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public sealed class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
