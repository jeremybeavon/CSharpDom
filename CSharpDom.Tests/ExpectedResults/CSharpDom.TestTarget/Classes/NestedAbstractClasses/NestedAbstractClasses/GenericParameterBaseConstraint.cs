namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedAbstractClasses
{
    public class ClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
