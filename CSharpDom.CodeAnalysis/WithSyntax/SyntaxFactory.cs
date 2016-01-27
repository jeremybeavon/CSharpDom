using System.Threading.Tasks;
using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public static class SyntaxFactory
    {
        public static Task<ISolutionSyntax> OpenSolutionAsync(string solutionFile)
        {
            return SolutionNode.OpenAsync(solutionFile, OpenSolution);
        }

        public static ISolutionSyntax OpenSolution(Solution solution)
        {
            return new SolutionNodeWithSyntax(solution);
        }

        public static ISolutionSyntax CreateSolutionForText(string sourceText)
        {
            return CreateSolutionNodeForText(sourceText);
        }

        internal static SolutionNodeWithSyntax CreateSolutionNodeForText(string sourceText)
        {
            SolutionId solutionId = SolutionId.CreateNewId();
            ProjectId projectId = ProjectId.CreateNewId();
            DocumentId documentId = DocumentId.CreateNewId(projectId);
            VersionStamp version = VersionStamp.Default;
            TextLoader textLoader = TextLoader.From(TextAndVersion.Create(SourceText.From(sourceText), version));
            DocumentInfo documentInfo = DocumentInfo.Create(documentId, "DocumentName").WithTextLoader(textLoader);
            ProjectInfo projectInfo = ProjectInfo.Create(projectId, version, "ProjectName", "AssemblyName", "C#");
            projectInfo = projectInfo.WithDocuments(new DocumentInfo[] { documentInfo });
            SolutionInfo solutionInfo = SolutionInfo.Create(solutionId, version, projects: new ProjectInfo[] { projectInfo });
            AdhocWorkspace workspace = new AdhocWorkspace();
            workspace.AddSolution(solutionInfo);
            return new SolutionNodeWithSyntax(workspace.CurrentSolution);
        }
    }
}
