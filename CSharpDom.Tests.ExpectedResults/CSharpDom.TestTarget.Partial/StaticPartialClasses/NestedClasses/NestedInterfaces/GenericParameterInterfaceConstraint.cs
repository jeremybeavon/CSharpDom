namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedInterfaces
{
    public static partial class StaticPartialClassWithNestedClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
