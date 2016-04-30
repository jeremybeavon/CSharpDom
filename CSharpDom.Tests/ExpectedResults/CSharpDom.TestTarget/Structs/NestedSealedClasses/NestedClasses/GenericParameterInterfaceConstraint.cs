namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedClasses
{
    public struct StructWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
