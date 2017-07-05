namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedInterfaces
{
    public class ClassWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
