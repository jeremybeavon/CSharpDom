namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedClassWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
