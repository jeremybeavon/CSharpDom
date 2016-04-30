namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
