namespace CSharpDom.TestTarget.SealedClasses.Constructors
{
    public sealed class SealedClassWithConstructorWithParametersWithModifiers
    {
        public SealedClassWithConstructorWithParametersWithModifiers(ref string text, out int integer, params object[] objects)
        {
            integer = default(int);
        }
    }
}
