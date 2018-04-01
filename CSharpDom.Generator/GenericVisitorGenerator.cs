using CSharpDom.CodeAnalysis;
using CSharpDom.CodeAnalysis.Expressions;
using CSharpDom.CodeAnalysis.Statements;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Generator
{
    public static class GenericVisitorGenerator
    {
        public static async Task GenerateGenericVisitor(DocumentWithCodeAnalysis document)
        {
            /*string baseDirectory = Path.GetFullPath(
                Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), @"..\..\..\.."));
            LoadedDocumentWithCodeAnalysis genericVisitorDocument = await LoadedDocumentWithCodeAnalysis.LoadFromFileAsync(
                Path.Combine(baseDirectory, @"CSharpDom\Common\GenericVisitor.cs"));
            foreach (StaticClassMethodWithCodeAnalysis method in
                genericVisitorDocument.Namespaces.First().Classes.StaticClasses.First().Methods)
            {
                IList<IStatementWithCodeAnalysis> statements = method.Body.Statements;
                if (statements.Count == 1 &&
                    statements[0] is ExpressionStatementWithCodeAnalysis expressionStatement &&
                    expressionStatement.Expression is MethodCallExpressionWithCodeAnalysis methodCall &&
                    methodCall.Expression is MemberExpressionWithCodeAnalysis member &&
                    member.ObjectExpression is IdentifierExpressionWithCodeAnalysis identifier &&
                    identifier.Name == "GenericChildVisitor")
                {
                    continue;
                }

                statements.Clear();

            }*/
        }
    }
}
