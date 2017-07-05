namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedInterfaces
{
    public struct StructWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public static partial class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
