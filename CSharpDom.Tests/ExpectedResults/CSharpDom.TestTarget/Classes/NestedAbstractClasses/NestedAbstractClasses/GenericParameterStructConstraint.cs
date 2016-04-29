namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedAbstractClasses
{
    public class ClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
