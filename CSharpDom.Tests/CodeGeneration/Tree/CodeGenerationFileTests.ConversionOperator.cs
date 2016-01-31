using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestClassWithImplicitConversionOperator()
        {
            const string expectedText = @"class TestClass
{
    public static implicit operator string(TestClass parameter1)
    {
        return null;
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            ConversionOperators = new Collection<ConversionOperator>()
                            {
                                new ConversionOperator()
                                {
                                    OperatorType = ConversionOperatorType.Implicit,
                                    ParameterName = "parameter1",
                                    ParameterType = new TypeReference("TestClass"),
                                    ReturnType = new TypeReference(typeof(string)),
                                    Body = new Collection<Statement>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithExplicitConversionOperator()
        {
            const string expectedText = @"class TestClass
{
    public static explicit operator string(TestClass parameter1)
    {
        return null;
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            ConversionOperators = new Collection<ConversionOperator>()
                            {
                                new ConversionOperator()
                                {
                                    OperatorType = ConversionOperatorType.Explicit,
                                    ParameterName = "parameter1",
                                    ParameterType = new TypeReference("TestClass"),
                                    ReturnType = new TypeReference(typeof(string)),
                                    Body = new Collection<Statement>()
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
            }).ToString().Should().Be(expectedText);
        }
    }
}
