namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedAbstractClassWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public abstract class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
