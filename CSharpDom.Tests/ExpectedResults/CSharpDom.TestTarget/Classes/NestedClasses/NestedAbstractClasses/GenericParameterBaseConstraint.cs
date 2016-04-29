namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedAbstractClasses
{
    public class ClassWithNestedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
