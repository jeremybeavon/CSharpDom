using CSharpDom.CodeAnalysis;
using CSharpDom.Tests.Common;
using CSharpDom.Text;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    public abstract class AbstractSolutionWithCodeAnalysisTests
    {
        protected void TestAbstractClassAsync(Type type)
        {
            TestType(type);
        }

        protected void TestClassAsync(Type type)
        {
            TestType(type);
        }

        protected void TestDelegatesAsync(Type type)
        {
            TestType(type);
        }

        protected void TestEnumsAsync(Type type)
        {
            TestType(type);
        }

        protected void TestInterfacesAsync(Type type)
        {
            TestType(type);
        }

        protected void TestStaticClassAsync(Type type)
        {
            TestType(type);
        }

        protected void TestSealedClassAsync(Type type)
        {
            TestType(type);
        }

        protected void TestStructAsync(Type type)
        {
            TestType(type);
        }

        private void TestType(Type type)
        {
            string expectedResult = TypeTextProvider.GetTypeText(type);
            SolutionWithCodeAnalysis solution = SolutionWithCodeAnalysis.GetSolutionForSourceCode(expectedResult);
            Task<LoadedDocumentWithCodeAnalysis> documentvoid =
                solution.Projects.First().Documents.First().LoadAsync();
            documentvoid.Wait();
            LoadedDocumentWithCodeAnalysis document = documentvoid.Result;
            string documentText = document.ToSourceCode();
            documentText.TrimEnd().Replace("\r", string.Empty).Should().Be(expectedResult.TrimEnd().Replace("\r", string.Empty));
        }
    }
}
