namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedInterfaceWithGenericParameterBaseClassConstraint
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
