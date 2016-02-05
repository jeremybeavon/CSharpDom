using System;
using System.Threading.Tasks;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection.Internal
{
    public sealed class DocumentWithReflection :
        AbstractDocument<ProjectWithReflection, SolutionWithReflection, AssemblyWithReflection>
    {
        private readonly ProjectWithReflection project;
        private readonly AssemblyWithReflection assembly;

        internal DocumentWithReflection(ProjectWithReflection project, AssemblyWithReflection assembly)
        {
            this.project = project;
            this.assembly = assembly;
        }

        public override string FullFilePath
        {
            get { return assembly.FullFilePath; }
        }

        public override ProjectWithReflection Project
        {
            get { return project; }
        }

        public override SolutionWithReflection Solution
        {
            get { return project.Solution; }
        }

        public override Task<AssemblyWithReflection> LoadAsync()
        {
            return Task.FromResult(assembly);
        }
    }
}
