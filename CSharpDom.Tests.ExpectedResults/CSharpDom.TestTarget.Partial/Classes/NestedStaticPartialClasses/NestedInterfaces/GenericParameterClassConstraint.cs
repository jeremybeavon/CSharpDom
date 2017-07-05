namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedInterfaces
{
    public class ClassWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
