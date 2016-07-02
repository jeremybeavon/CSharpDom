namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedClasses
{
    public class ClassWithNestedSealedClassWithNestedClassWith2ImplementedInterfaces
    {
        public sealed class Class
        {
            public class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
