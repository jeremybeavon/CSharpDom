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
        protected Task TestAbstractClassAsync(Type type)
        {
            return TestType(type);
        }

        protected Task TestClassAsync(Type type)
        {
            return TestType(type);
        }

        protected Task TestDelegatesAsync(Type type)
        {
            return TestType(type);
        }

        protected Task TestEnumsAsync(Type type)
        {
            return TestType(type);
        }

        protected Task TestInterfacesAsync(Type type)
        {
            return TestType(type);
        }

        protected Task TestStaticClassAsync(Type type)
        {
            return TestType(type);
        }

        protected Task TestSealedClassAsync(Type type)
        {
            return TestType(type);
        }

        protected Task TestStructAsync(Type type)
        {
            return TestType(type);
        }

        private async Task TestType(Type type)
        {
            string expectedResult = TypeTextProvider.GetTypeText(type);
            SolutionWithCodeAnalysis solution = SolutionWithCodeAnalysis.GetSolutionForSourceCode(expectedResult);
            LoadedDocumentWithCodeAnalysis document = await solution.Projects.First().Documents.First().LoadAsync();
            string documentText = document.ToSourceCode();
            documentText.TrimEnd().Replace("\r", string.Empty).Should().Be(expectedResult.TrimEnd().Replace("\r", string.Empty));
        }
    }
}
