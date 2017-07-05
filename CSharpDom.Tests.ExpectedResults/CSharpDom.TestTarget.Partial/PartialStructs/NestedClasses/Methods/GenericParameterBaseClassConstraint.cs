namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Methods
{
    public partial struct PartialStructWithWithNestedClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
