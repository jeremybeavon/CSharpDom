namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedInterfaces
{
    public struct StructWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
