namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedInterfaces
{
    public partial class PartialClassWithNestedStructWithNestedInterfaceWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public interface Interface : IInterface1, IInterface2
            {
            }
        }
    }
}
