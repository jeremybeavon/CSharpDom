namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedPartialClassWithExplicitInterfaceMethodWithParametersWithModifiers
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
