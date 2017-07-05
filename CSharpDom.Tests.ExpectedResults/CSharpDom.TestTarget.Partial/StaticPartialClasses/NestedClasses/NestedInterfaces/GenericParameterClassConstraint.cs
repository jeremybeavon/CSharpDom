namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedInterfaces
{
    public static partial class StaticPartialClassWithNestedClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
