namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
