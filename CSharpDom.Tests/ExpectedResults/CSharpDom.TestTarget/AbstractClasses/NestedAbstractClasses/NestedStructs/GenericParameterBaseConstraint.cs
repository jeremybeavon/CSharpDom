namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}
