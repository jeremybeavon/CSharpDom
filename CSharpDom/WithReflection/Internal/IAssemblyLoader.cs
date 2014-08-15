using System.Reflection;

namespace CSharpDom.WithReflection.Internal
{
    internal interface IAssemblyLoader
    {
        Assembly LoadAssembly(ProjectNode project);
    }
}
