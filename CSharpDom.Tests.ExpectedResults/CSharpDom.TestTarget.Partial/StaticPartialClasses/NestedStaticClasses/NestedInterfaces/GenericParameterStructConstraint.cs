namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedInterfaces
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterStructConstraint
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
