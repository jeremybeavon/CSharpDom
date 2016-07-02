namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedInterfaces
{
    public class ClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
