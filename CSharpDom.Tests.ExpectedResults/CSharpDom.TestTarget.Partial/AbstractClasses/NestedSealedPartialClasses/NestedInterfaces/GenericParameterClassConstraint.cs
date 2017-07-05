namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
