namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedAbstractClasses
{
    public class ClassWithNestedStructWithNestedAbstractClassWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public abstract class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
