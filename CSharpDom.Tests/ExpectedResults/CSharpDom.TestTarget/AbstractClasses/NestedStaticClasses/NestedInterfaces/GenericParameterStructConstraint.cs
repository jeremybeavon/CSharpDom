namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
