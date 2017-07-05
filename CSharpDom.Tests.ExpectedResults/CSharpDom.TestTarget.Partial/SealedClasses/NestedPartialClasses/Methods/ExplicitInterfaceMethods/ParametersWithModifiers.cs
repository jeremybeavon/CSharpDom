namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedPartialClassWithExplicitInterfaceMethodWithParametersWithModifiers
    {
        public class Class : IInterfaceWithMethodWithParametersWithModifiers
        {
            void IInterfaceWithMethodWithParametersWithModifiers.Method(ref string parameter1, out string parameter2, params string[] parameters)
            {
                parameter2 = default(string);
            }
        }
    }
}
