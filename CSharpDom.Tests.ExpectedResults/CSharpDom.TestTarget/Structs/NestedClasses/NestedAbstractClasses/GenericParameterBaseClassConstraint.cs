namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedAbstractClasses
{
    public struct StructWithNestedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
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
