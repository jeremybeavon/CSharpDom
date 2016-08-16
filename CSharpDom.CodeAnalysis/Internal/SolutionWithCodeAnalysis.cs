using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.CodeAnalysis.Internal
{
    public sealed class SolutionWithCodeAnalysis : AbstractSolution<ProjectWithCodeAnalysis>
    {
        private readonly AssemblyWithCodeAnalysis assembly;
        private readonly IReadOnlyCollection<ProjectWithCodeAnalysis> projects;

        internal SolutionWithCodeAnalysis(AssemblyWithCodeAnalysis assembly)
        {
            this.assembly = assembly;
            projects = new ProjectWithCodeAnalysis[] { new ProjectWithCodeAnalysis(this, assembly) };
        }

        public override IReadOnlyCollection<ProjectWithCodeAnalysis> Projects
        {
            get { return projects; }
        }
    }
}
