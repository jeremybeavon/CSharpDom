namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedInterfaces
{
    public struct StructWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public sealed partial class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
