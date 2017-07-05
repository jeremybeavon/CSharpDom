namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
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
