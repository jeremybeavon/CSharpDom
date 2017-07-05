namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedInterfaces
{
    public class ClassWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
