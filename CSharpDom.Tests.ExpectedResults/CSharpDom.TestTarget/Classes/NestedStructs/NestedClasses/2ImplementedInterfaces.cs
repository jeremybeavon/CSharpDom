namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedClasses
{
    public class ClassWithNestedStructWithNestedClassWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
