namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public sealed partial class SealedPartialClassWithNestedClassWithExplicitInterfaceMethodWithParametersWithModifiers
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
