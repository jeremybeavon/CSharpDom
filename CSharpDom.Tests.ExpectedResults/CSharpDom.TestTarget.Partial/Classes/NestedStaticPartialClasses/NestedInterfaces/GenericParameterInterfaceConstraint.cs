namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedInterfaces
{
    public class ClassWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
