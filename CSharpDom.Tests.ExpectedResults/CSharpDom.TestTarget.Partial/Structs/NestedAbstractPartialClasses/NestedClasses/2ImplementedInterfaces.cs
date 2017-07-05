namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedClasses
{
    public struct StructWithNestedAbstractPartialClassWithNestedPartialClassWith2ImplementedInterfaces
    {
        public abstract partial class Class
        {
            public class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
