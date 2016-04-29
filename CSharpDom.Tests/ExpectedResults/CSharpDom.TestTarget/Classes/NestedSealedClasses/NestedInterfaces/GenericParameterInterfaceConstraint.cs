namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedInterfaces
{
    public class ClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
