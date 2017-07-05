namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedInterfaces
{
    public static partial class StaticPartialClassWithNestedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
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
