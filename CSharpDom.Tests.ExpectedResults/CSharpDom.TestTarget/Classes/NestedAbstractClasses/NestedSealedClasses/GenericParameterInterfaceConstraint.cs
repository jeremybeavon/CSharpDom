namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedSealedClasses
{
    public class ClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
