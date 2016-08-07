namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedAbstractClasses
{
    public struct StructWithNestedClassWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
