using System;
using System.Threading.Tasks;
using CSharpDom.BaseClasses;

namespace CSharpDom.Mono.Cecil.Internal
{
    public sealed class DocumentWithMonoCecil :
        AbstractDocument<ProjectWithMonoCecil, SolutionWithMonoCecil, AssemblyWithMonoCecil>
    {
        private readonly ProjectWithMonoCecil project;
        private readonly AssemblyWithMonoCecil assembly;

        internal DocumentWithMonoCecil(ProjectWithMonoCecil project, AssemblyWithMonoCecil assembly)
        {
            this.project = project;
            this.assembly = assembly;
        }

        public override string FullFilePath
        {
            get { return assembly.FullFilePath; }
        }

        public override ProjectWithMonoCecil Project
        {
            get { return project; }
        }

        public override SolutionWithMonoCecil Solution
        {
            get { return project.Solution; }
        }

        public override Task<AssemblyWithMonoCecil> LoadAsync()
        {
            return Task.FromResult(assembly);
        }
    }
}
