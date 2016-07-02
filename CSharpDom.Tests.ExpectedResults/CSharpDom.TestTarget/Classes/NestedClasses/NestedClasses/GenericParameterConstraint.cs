namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedClasses
{
    public class ClassWithNestedClassWithNestedClassWithGenericParameterClassConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
