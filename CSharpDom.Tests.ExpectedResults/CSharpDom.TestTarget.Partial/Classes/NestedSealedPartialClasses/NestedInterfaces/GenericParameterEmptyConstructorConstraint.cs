namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedInterfaces
{
    public class ClassWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public sealed partial class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
