namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedAbstractClasses
{
    public class ClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
