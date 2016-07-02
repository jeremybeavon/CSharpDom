namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedClasses
{
    public class ClassWithNestedAbstractClassWithNestedClassWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
