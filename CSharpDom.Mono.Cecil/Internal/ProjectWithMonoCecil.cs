using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.BaseClasses;

namespace CSharpDom.Mono.Cecil.Internal
{
    public sealed class ProjectWithMonoCecil :
        AbstractProject<SolutionWithMonoCecil, DocumentWithMonoCecil, AssemblyWithMonoCecil>
    {
        private readonly SolutionWithMonoCecil solution;
        private readonly AssemblyWithMonoCecil assembly;
        private readonly IReadOnlyCollection<DocumentWithMonoCecil> documents;

        internal ProjectWithMonoCecil(SolutionWithMonoCecil solution, AssemblyWithMonoCecil assembly)
        {
            this.solution = solution;
            this.assembly = assembly;
            documents = new DocumentWithMonoCecil[] { new DocumentWithMonoCecil(this, assembly) };
        }

        public override IReadOnlyCollection<DocumentWithMonoCecil> Documents
        {
            get { return documents; }
        }

        public override SolutionWithMonoCecil Solution
        {
            get { return solution; }
        }

        public override Task<AssemblyWithMonoCecil> LoadAsync()
        {
            return Task.FromResult(assembly);
        }
    }
}
