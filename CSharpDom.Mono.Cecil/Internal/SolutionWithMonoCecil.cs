using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.Mono.Cecil.Internal
{
    public sealed class SolutionWithMonoCecil : AbstractSolution<ProjectWithMonoCecil>
    {
        private readonly AssemblyWithMonoCecil assembly;
        private readonly IReadOnlyCollection<ProjectWithMonoCecil> projects;

        internal SolutionWithMonoCecil(AssemblyWithMonoCecil assembly)
        {
            this.assembly = assembly;
            projects = new ProjectWithMonoCecil[] { new ProjectWithMonoCecil(this, assembly) };
        }

        public override IReadOnlyCollection<ProjectWithMonoCecil> Projects
        {
            get { return projects; }
        }
    }
}
