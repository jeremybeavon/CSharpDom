namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedInterfaces
{
    public class ClassWithNestedStructWithNestedInterfaceWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public interface Interface : IInterface1, IInterface2
            {
            }
        }
    }
}
