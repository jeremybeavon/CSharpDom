namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedAbstractClasses
{
    public struct StructWithNestedSealedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
