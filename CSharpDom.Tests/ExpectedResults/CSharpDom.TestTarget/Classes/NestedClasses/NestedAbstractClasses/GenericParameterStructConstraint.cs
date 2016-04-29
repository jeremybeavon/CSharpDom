namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedAbstractClasses
{
    public class ClassWithNestedClassWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
