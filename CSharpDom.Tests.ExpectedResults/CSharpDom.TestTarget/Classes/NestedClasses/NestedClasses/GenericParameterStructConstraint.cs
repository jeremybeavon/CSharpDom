namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedClasses
{
    public class ClassWithNestedClassWithNestedClassWithGenericParameterStructConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
