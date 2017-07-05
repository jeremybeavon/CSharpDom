namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedInterfaces
{
    public struct StructWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public sealed partial class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
