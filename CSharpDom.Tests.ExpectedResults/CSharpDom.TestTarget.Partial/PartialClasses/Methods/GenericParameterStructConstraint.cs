namespace CSharpDom.TestTarget.Partial.PartialClasses.Methods
{
    public partial class PartialClassWithMethodWithGenericParameterStructConstraint
    {
        public T Method<T>()
            where T : struct
        {
            return default(T);
        }
    }
}
