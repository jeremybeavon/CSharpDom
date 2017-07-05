namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Methods
{
    public partial struct PartialStructWithWithNestedClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}
