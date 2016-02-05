using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection.Internal
{
    public sealed class ProjectWithReflection :
        AbstractProject<SolutionWithReflection, DocumentWithReflection, AssemblyWithReflection>
    {
        private readonly SolutionWithReflection solution;
        private readonly AssemblyWithReflection assembly;
        private readonly IReadOnlyCollection<DocumentWithReflection> documents;

        internal ProjectWithReflection(SolutionWithReflection solution, AssemblyWithReflection assembly)
        {
            this.solution = solution;
            this.assembly = assembly;
            documents = new DocumentWithReflection[] { new DocumentWithReflection(this, assembly) };
        }

        public override IReadOnlyCollection<DocumentWithReflection> Documents
        {
            get { return documents; }
        }

        public override SolutionWithReflection Solution
        {
            get { return solution; }
        }

        public override Task<AssemblyWithReflection> LoadAsync()
        {
            return Task.FromResult(assembly);
        }
    }
}
