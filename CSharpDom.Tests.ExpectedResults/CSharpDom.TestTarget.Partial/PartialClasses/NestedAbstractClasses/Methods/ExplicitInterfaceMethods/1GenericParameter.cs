namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithNestedAbstractClassWithExplicitInterfaceMethodWith1GenericParameter
    {
        public abstract class Class : IInterfaceWithMethodWith1GenericParameter
        {
            T IInterfaceWithMethodWith1GenericParameter.Method<T>()
            {
                return default(T);
            }
        }
    }
}
