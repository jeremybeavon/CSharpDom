using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.WithReflection.Internal
{
    internal sealed class AppDomainAssemblyLoader : IAssemblyLoader
    {
        public Assembly LoadAssembly(ProjectNode project)
        {
            return AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(
                assembly => assembly.GetName().Name == project.Project.AssemblyName);
        }
    }
}
