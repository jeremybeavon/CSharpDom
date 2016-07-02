namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedInterfaces
{
    public class ClassWithNestedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
