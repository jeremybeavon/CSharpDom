namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
