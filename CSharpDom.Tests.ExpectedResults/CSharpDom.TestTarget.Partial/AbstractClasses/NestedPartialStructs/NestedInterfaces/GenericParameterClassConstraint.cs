namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedInterfaces
{
    public abstract class AbstractClassWithNestedStructWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
