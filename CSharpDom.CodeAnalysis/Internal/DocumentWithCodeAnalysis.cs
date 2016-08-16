using System;
using System.Threading.Tasks;
using CSharpDom.BaseClasses;

namespace CSharpDom.CodeAnalysis.Internal
{
    public sealed class DocumentWithCodeAnalysis :
        AbstractDocument<ProjectWithCodeAnalysis, SolutionWithCodeAnalysis, AssemblyWithCodeAnalysis>
    {
        private readonly ProjectWithCodeAnalysis project;
        private readonly AssemblyWithCodeAnalysis assembly;

        internal DocumentWithCodeAnalysis(ProjectWithCodeAnalysis project, AssemblyWithCodeAnalysis assembly)
        {
            this.project = project;
            this.assembly = assembly;
        }

        public override string FullFilePath
        {
            get { return assembly.FullFilePath; }
        }

        public override ProjectWithCodeAnalysis Project
        {
            get { return project; }
        }

        public override SolutionWithCodeAnalysis Solution
        {
            get { return project.Solution; }
        }

        public override Task<AssemblyWithCodeAnalysis> LoadAsync()
        {
            return Task.FromResult(assembly);
        }
    }
}
