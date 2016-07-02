namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedClasses
{
    public struct StructWithNestedAbstractClassWithNestedClassWith2ImplementedInterfaces
    {
        public abstract class Class
        {
            public class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
