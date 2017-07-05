namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public static class StaticClassWithNestedPartialClassWithExplicitInterfaceMethodWithParametersWithModifiers
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
