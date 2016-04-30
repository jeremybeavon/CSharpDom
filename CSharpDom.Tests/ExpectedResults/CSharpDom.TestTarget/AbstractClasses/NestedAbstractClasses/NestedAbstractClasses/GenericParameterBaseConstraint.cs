namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
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
