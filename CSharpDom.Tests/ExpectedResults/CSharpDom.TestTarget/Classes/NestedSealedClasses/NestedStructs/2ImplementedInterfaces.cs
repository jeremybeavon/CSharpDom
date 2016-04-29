namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedStructs
{
    public class ClassWithNestedSealedClassWithNestedStructWith2ImplementedInterfaces
    {
        public sealed class Class
        {
            public struct NestedStruct : IInterface1, IInterface2
            {
            }
        }
    }
}
