namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedPartialClassWithExplicitInterfaceMethodWith1GenericParameter
    {
        public class Class : IInterfaceWithMethodWith1GenericParameter
        {
            T IInterfaceWithMethodWith1GenericParameter.Method<T>()
            {
                return default(T);
            }
        }
    }
}
