namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedStaticClasses
{
    public class ClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
