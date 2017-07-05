namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedInterfaces
{
    public struct StructWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
