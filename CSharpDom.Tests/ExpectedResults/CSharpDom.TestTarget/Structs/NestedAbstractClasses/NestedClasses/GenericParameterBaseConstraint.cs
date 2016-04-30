namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedClasses
{
    public struct StructWithNestedAbstractClassWithNestedClassWithGenericParameterBaseClassConstraint
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
