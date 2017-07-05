namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedInterfaces
{
    public struct StructWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
