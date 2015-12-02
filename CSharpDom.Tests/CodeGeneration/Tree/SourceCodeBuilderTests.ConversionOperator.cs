using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestClassWithImplicitConversionOperator()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            ConversionOperators = new CodeGenerationCollection<ConversionOperator>()
                            {
                                new ConversionOperator()
                                {
                                    OperatorType = ConversionOperatorType.Implicit,
                                    ParameterName = "parameter1",
                                    ParameterType = new TypeReference("TestClass"),
                                    ReturnType = new TypeReference(typeof(string)),
                                    Body = new CodeGenerationCollection<Statement>()
                                    {
                                        new ReturnStatement()
                                        {
                                            RawExpression = "null"
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public static implicit operator string(TestClass parameter1)
    {
        return null;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithExplicitConversionOperator()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            ConversionOperators = new CodeGenerationCollection<ConversionOperator>()
                            {
                                new ConversionOperator()
                                {
                                    OperatorType = ConversionOperatorType.Explicit,
                                    ParameterName = "parameter1",
                                    ParameterType = new TypeReference("TestClass"),
                                    ReturnType = new TypeReference(typeof(string)),
                                    Body = new CodeGenerationCollection<Statement>()
                                    {
                                        new ReturnStatement()
                                        {
                                            RawExpression = "null"
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public static explicit operator string(TestClass parameter1)
    {
        return null;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
