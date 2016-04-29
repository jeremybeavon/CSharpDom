namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedInterfaces
{
    public class ClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
