using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.BaseClasses;

namespace CSharpDom.CodeAnalysis.Internal
{
    public sealed class ProjectWithCodeAnalysis :
        AbstractProject<SolutionWithCodeAnalysis, DocumentWithCodeAnalysis, AssemblyWithCodeAnalysis>
    {
        private readonly SolutionWithCodeAnalysis solution;
        private readonly AssemblyWithCodeAnalysis assembly;
        private readonly IReadOnlyCollection<DocumentWithCodeAnalysis> documents;

        internal ProjectWithCodeAnalysis(SolutionWithCodeAnalysis solution, AssemblyWithCodeAnalysis assembly)
        {
            this.solution = solution;
            this.assembly = assembly;
            documents = new DocumentWithCodeAnalysis[] { new DocumentWithCodeAnalysis(this, assembly) };
        }

        public override IReadOnlyCollection<DocumentWithCodeAnalysis> Documents
        {
            get { return documents; }
        }

        public override SolutionWithCodeAnalysis Solution
        {
            get { return solution; }
        }

        public override Task<AssemblyWithCodeAnalysis> LoadAsync()
        {
            return Task.FromResult(assembly);
        }
    }
}
