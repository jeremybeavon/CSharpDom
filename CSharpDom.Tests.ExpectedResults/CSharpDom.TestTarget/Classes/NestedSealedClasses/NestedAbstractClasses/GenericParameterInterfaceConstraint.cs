namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedAbstractClasses
{
    public class ClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
