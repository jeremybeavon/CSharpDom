namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedClasses
{
    public class ClassWithNestedAbstractClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
