using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SolutionWithCodeAnalysis :
        EditableSolution<ProjectWithCodeAnalysis>,
        IHasSyntax<Solution>,
        IHasNode<Solution>
    {
        private readonly Node<SolutionWithCodeAnalysis, Solution> node;
        private readonly ChildNodeList<SolutionWithCodeAnalysis, Solution, ProjectWithCodeAnalysis, Project> projects;

        internal SolutionWithCodeAnalysis(Workspace workspace, Solution solution)
        {
            node = new Node<SolutionWithCodeAnalysis, Solution>(this, solution);
            projects = new ChildNodeList<SolutionWithCodeAnalysis, Solution, ProjectWithCodeAnalysis, Project>(
                node,
                new ProjectSyntaxList(node),
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

        public Workspace Workspace { get; private set; }

        INode<Solution> IHasNode<Solution>.Node
        {
            get { return node; }
        }

        public static async Task<SolutionWithCodeAnalysis> OpenAsync(string fileName)
        {
            MSBuildWorkspace workspace = MSBuildWorkspace.Create();
            return new SolutionWithCodeAnalysis(workspace, await workspace.OpenSolutionAsync(fileName));
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
            return new SolutionWithCodeAnalysis(workspace, workspace.CurrentSolution);
        }
    }
}
