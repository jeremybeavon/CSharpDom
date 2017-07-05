namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
