using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*SourceCodeBuilder builder = new SourceCodeBuilder\(\);\r?\n\s+(?<a>\(new CodeGenerationFile(?:.|\r|\n)+?)\.Accept\(builder\);\r?\n\s+(?<b>const string expectedText = @"(?:[^"]|(?:"")|\r|\n)+";)\r?\n\s+builder\.ToString\(\)\.Should\(\)\.Be\(expectedText\);


${b}             \r\n${a}.ToString().Should().Be(expectedText);*/

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    [TestClass]
    public sealed partial class SourceCodeBuilderTests
    {
        /*[TestMethod]
        public void Test1UsingAnd1Namespace()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Usings =
                {
                    new UsingDeclaration("System")
                },
                Namespaces =
                {
                    new Namespace("Namespace1")
                }
            }).Accept(builder);
            const string expectedText = @"using System;

namespace Namespace1
{
}";
            builder.ToString().Should().Be(expectedText);
        }*/
    }
}
