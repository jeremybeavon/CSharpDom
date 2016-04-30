namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedSealedClasses
{
    public struct StructWithNestedClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
