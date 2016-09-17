using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Text;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SolutionWithCodeAnalysis :
        EditableSolution<ProjectWithCodeAnalysis>,
        IHasSyntax<Solution>,
        IHasNode<Solution>
    {
        private readonly Node<SolutionWithCodeAnalysis, Solution> node;
        private readonly ImmutableListWrapper<SolutionWithCodeAnalysis, Solution, ProjectWithCodeAnalysis, Project> projects;

        internal SolutionWithCodeAnalysis(Solution solution)
        {
            node = new Node<SolutionWithCodeAnalysis, Solution>(this, solution);
            projects = new ImmutableListWrapper<SolutionWithCodeAnalysis, Solution, ProjectWithCodeAnalysis, Project>(
                node,
                new ProjectListWrapper(node),
                () => new ProjectWithCodeAnalysis());
        }

        public override ICollection<ProjectWithCodeAnalysis> Projects
        {
            get { return projects; }
            set { throw new NotSupportedException(); }
        }

        public Solution Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        INode<Solution> IHasNode<Solution>.Node
        {
            get { return node; }
        }

        public static async Task<SolutionWithCodeAnalysis> OpenAsync(string fileName)
        {
            return new SolutionWithCodeAnalysis(await MSBuildWorkspace.Create().OpenSolutionAsync(fileName));
        }

        public static SolutionWithCodeAnalysis GetSolutionForSourceCode(string code)
        {
            SolutionId solutionId = SolutionId.CreateNewId();
            ProjectId projectId = ProjectId.CreateNewId();
            DocumentId documentId = DocumentId.CreateNewId(projectId);
            VersionStamp version = VersionStamp.Default;
            TextLoader textLoader = TextLoader.From(TextAndVersion.Create(SourceText.From(code), version));
            DocumentInfo documentInfo = DocumentInfo.Create(documentId, "DocumentName").WithTextLoader(textLoader);
            ProjectInfo projectInfo = ProjectInfo.Create(projectId, version, "ProjectName", "AssemblyName", "C#");
            projectInfo = projectInfo.WithDocuments(new DocumentInfo[] { documentInfo });
            SolutionInfo solutionInfo = SolutionInfo.Create(solutionId, version, projects: new ProjectInfo[] { projectInfo });
            AdhocWorkspace workspace = new AdhocWorkspace();
            workspace.AddSolution(solutionInfo);
            return new SolutionWithCodeAnalysis(workspace.CurrentSolution);
        }
    }
}
