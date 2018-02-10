using CSharpDom.CodeAnalysis;
using CSharpDom.CodeAnalysis.Statements;
using CSharpDom.CodeAnalysis.Expressions;
using CSharpDom.Text;
using CSharpDom.Text.Rules;
using Nito.AsyncEx;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpDom.GenericChildVisitorGenerator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            AsyncContext.Run(GenerateForwardingVisitor);
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
