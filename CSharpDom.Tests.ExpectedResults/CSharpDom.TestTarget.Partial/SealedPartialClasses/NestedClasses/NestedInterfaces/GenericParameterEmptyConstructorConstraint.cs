namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
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
