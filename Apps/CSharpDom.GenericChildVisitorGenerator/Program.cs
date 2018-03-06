using CSharpDom.CodeAnalysis;
using CSharpDom.CodeAnalysis.Expressions;
using CSharpDom.CodeAnalysis.Statements;
using CSharpDom.Text;
using CSharpDom.Text.Rules;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Nito.AsyncEx;
using System;
using System.Collections.Generic;
using System.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpDom.GenericChildVisitorGenerator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            AsyncContext.Run(GenerateWrapperImplementations);
        }
        
        private static async Task GenerateWrapperImplementations()
        {
            string baseDirectory = Path.GetFullPath(
                Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), @"..\..\..\.."));
            ProjectWithCodeAnalysis project = await ProjectWithCodeAnalysis.OpenAsync(
                Path.Combine(baseDirectory, @"CSharpDom\CSharpDom.csproj"));
            project.Lock();
            foreach (DocumentWithCodeAnalysis document in project.Documents
                .Where(document => document.FullFilePath.Contains(@"CSharpDom\Wrappers\Internal"))
                .OrderBy(document => document.FullFilePath))
            {
                document.IsLocked = true;
                bool isEdited = false;
                LoadedDocumentWithCodeAnalysis loadedDocument = await document.LoadAsync();
                using (CodeAnalysisSettings.AllowEdits(loadedDocument))
                {
                    SealedClassWithCodeAnalysis @class = loadedDocument.Namespaces.First().Classes.SealedClasses.FirstOrDefault();
                    if (@class == null)
                    {
                        continue;
                    }

                    foreach (SealedClassPropertyWithCodeAnalysis property in @class.Properties
                        .Where(property => property.GetAccessor.Body.Statements.FirstOrDefault() is ThrowStatementWithCodeAnalysis)
                        .ToArray())
                    {
                        isEdited = true;
                        string propertyName = property.Name;
                        string fieldName = propertyName.Substring(0, 1).ToLower() + propertyName.Substring(1);
                        SealedClassFieldWithCodeAnalysis field = new SealedClassFieldWithCodeAnalysis(
                            ClassMemberVisibilityModifier.Private,
                            new DelegateReferenceWithCodeAnalysis("Func", property.PropertyType),
                            fieldName);
                        @class.Fields.Fields.Add(field);
                        IList<IStatementWithCodeAnalysis> statements = property.GetAccessor.Body.Statements;
                        statements.Clear();
                        statements.Add(
                            StatementFactory.Return(ExpressionFactory.MethodCall(ExpressionFactory.Identifier(fieldName))));
                    }
                }

                if (isEdited)
                {
                    string sourceCode = loadedDocument.ToSourceCode();
                    File.WriteAllText(document.FullFilePath, sourceCode);
                }
            }
        }

        private static async Task LoadImplementInterfaceAsync()
        {
            var assembly = Assembly.Load("Microsoft.CodeAnalysis.CSharp.Features");
            var configuration = new ContainerConfiguration().WithAssembly(assembly);
            var container = configuration.CreateContainer();
            var test = container.GetExports<CodeFixProvider>().ToArray();
            var test2 = test.FirstOrDefault(provider =>
                (Attribute.GetCustomAttribute(provider.GetType(), typeof(ExportCodeFixProviderAttribute)) as ExportCodeFixProviderAttribute)?.Name == "ImplementInterface");
            string solutionFile = Path.Combine(
                Path.GetDirectoryName(typeof(Program).Assembly.Location),
                @"..\..\..\..\CSharpDom.sln");
            solutionFile = Path.GetFullPath(solutionFile);
            SolutionWithCodeAnalysis solution = await SolutionWithCodeAnalysis.OpenAsync(solutionFile);
            //(Workspace, ProjectWithCodeAnalysis) project = await ProjectWithCodeAnalysis.OpenWithWorkspaceAsync(projectFile);
            DocumentWithCodeAnalysis document = solution.Projects
                .First(project => project.Syntax.Name == "CSharpDom.EditableInterfaceGenerator")
                .Documents.First();
            Compilation compilation = await document.Syntax.Project.GetCompilationAsync();
            //SyntaxGenerator generator = document.Syntax.get
            LoadedDocumentWithCodeAnalysis loadedDocument = await document.LoadAsync();
            var syntax = loadedDocument.Namespaces.First().Classes.SealedClasses.First().ImplementedInterfaces.First().Syntax;
            List<CodeAction> actions = new List<CodeAction>();
            var descriptor = new DiagnosticDescriptor("CS0535", "CS0535", "CS0535", "CS0535", DiagnosticSeverity.Error, true);
            CodeFixContext context = new CodeFixContext(
                document.Syntax,
                Diagnostic.Create(descriptor, Location.Create(syntax.SyntaxTree, syntax.Span)),
                (action, diagnostics) => actions.Add(action),
                CancellationToken.None);
            await test2.RegisterCodeFixesAsync(context);
            var operations = await actions[0].GetOperationsAsync(CancellationToken.None);
            foreach (var operation in operations)
            {
                operation.Apply(solution.Syntax.Workspace, CancellationToken.None);
            }
            actions.GetHashCode();
        }
        
        private static async Task GenerateForwardingVisitor()
        {
            string visitorFileName = Path.Combine(
                Path.GetDirectoryName(typeof(Program).Assembly.Location),
                @"..\..\..\..\CSharpDom\Common\GenericChildVisitor.cs");
            visitorFileName = Path.GetFullPath(visitorFileName);
            LoadedDocumentWithCodeAnalysis loadedDocument =
                await LoadedDocumentWithCodeAnalysis.LoadFromFileAsync(visitorFileName);
            StaticClassWithCodeAnalysis visitorClass = loadedDocument.Namespaces.First().Classes.StaticClasses.First();
            using (CodeAnalysisSettings.AllowEdits(visitorClass))
            {
                foreach (StaticClassMethodWithCodeAnalysis method in
                    visitorClass.Methods.Where(method => method.GenericParameters.LastOrDefault()?.Name != "TVisitor"))
                {
                    Console.WriteLine($"Editing: {method.Name}");
                    UnspecifiedTypeReferenceWithCodeAnalysis visitableType = 
                        (UnspecifiedTypeReferenceWithCodeAnalysis)method.Parameters[0].ParameterType;
                    InterfaceReferenceWithCodeAnalysis visitorType = new InterfaceReferenceWithCodeAnalysis(
                        "IVisitable",
                        TypeReferenceFactory.GenericParameter("TVisitor"));
                    foreach (GenericParameterDeclarationWithCodeAnalysis genericParameter in 
                        method.GenericParameters)
                    {
                        string genericParameterName = genericParameter.Name;
                        if (genericParameterName != "TDocument" &&
                            genericParameterName != "TProject" &&
                            genericParameterName != "TSolution")
                        {
                            genericParameter.InterfaceConstraints.Add(visitorType);
                        }
                    }

                    string newName = Regex.Replace(visitableType.Name, "^I", "T");
                    method.Parameters[0].ParameterType = TypeReferenceFactory.GenericParameter(newName);
                    method.Parameters[1].ParameterType = TypeReferenceFactory.GenericParameter("TVisitor");
                    GenericParameterDeclarationWithCodeAnalysis newGenericParameter =
                        new GenericParameterDeclarationWithCodeAnalysis(newName)
                        {
                            InterfaceConstraints =
                            {
                                new InterfaceReferenceWithCodeAnalysis(visitableType)
                            }
                        };
                    method.GenericParameters.Insert(0, newGenericParameter);
                    method.GenericParameters.Add(new GenericParameterDeclarationWithCodeAnalysis("TVisitor"));
                    int statementIndex = -1;
                    int parameterIndex = 1;
                    foreach (IStatementWithCodeAnalysis statement in method.Body.Statements)
                    {
                        statementIndex++;
                        if (!(statement is ExpressionStatementWithCodeAnalysis expression) ||
                            !(expression.Expression is MethodCallExpressionWithCodeAnalysis methodCall) ||
                            !(methodCall.Expression is MemberExpressionWithCodeAnalysis memberCall) ||
                            !(memberCall.ObjectExpression is NewExpressionWithCodeAnalysis newObjectCall))
                        {
                            continue;
                        }

                        UnspecifiedTypeReferenceWithCodeAnalysis type =
                            newObjectCall.Type as UnspecifiedTypeReferenceWithCodeAnalysis;
                        string typeName = type.Name.Replace("Wrapper", string.Empty);
                        string genericTypeName = $"T{typeName}";
                        string parameterName = $"{typeName.Substring(0, 1).ToLower()}{typeName.Substring(1)}Factory";
                        newGenericParameter = new GenericParameterDeclarationWithCodeAnalysis(genericTypeName)
                        {
                            InterfaceConstraints =
                            {
                                new InterfaceReferenceWithCodeAnalysis(
                                    $"I{typeName}",
                                    type.GenericParameters.ToArray()),
                                visitorType
                            }
                        };
                        method.GenericParameters.Insert(parameterIndex, newGenericParameter);
                        ITypeReferenceWithCodeAnalysis parameterType = TypeReferenceFactory.Delegate(
                            "Func",
                            TypeReferenceFactory.GenericParameter(newName),
                            TypeReferenceFactory.GenericParameter(genericTypeName));
                        MethodParameterWithCodeAnalysis parameter = new MethodParameterWithCodeAnalysis(
                            parameterType,
                            parameterName);
                        method.Parameters.Insert(parameterIndex, parameter);
                        parameterIndex++;
                        memberCall.ObjectExpression = ExpressionFactory.MethodCall(
                            ExpressionFactory.Identifier(parameterName),
                            ExpressionFactory.Identifier(method.Parameters[0].Name));
                    }
                }
            }

            const int maximumLineLength = 120;
            string sourceCode = loadedDocument.ToSourceCode(
                new IndentMethodParametersIfTooLongRule(maximumLineLength));
            File.WriteAllText(visitorFileName, sourceCode);
        }
    }
}
