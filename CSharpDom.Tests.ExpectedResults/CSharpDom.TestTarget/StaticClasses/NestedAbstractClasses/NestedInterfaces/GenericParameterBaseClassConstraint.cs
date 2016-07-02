namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedInterfaces
{
    public static class StaticClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
