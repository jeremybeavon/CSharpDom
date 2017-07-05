namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedInterfaces
{
    public struct StructWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
