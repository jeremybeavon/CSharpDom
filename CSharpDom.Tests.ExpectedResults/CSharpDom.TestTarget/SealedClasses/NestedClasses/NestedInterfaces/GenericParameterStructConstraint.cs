namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
