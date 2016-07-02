namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
