namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
