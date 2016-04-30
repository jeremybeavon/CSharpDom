namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
