namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedInterfaces
{
    public abstract class AbstractClassWithNestedStructWithNestedInterfaceWithGenericParameterStructConstraint
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
