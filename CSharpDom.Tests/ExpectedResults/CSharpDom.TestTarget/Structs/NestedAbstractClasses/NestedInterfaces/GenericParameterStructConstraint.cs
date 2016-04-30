namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedInterfaces
{
    public struct StructWithNestedAbstractClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
