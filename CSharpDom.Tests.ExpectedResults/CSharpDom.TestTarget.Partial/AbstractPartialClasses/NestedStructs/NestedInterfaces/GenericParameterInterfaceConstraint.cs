namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
