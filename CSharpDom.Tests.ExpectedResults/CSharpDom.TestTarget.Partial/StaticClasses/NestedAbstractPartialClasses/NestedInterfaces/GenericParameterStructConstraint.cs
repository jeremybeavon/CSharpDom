namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedInterfaces
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
