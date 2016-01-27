using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestClassWithPlusUnaryOperator()
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
                            UnaryOperators = new CodeGenerationCollection<UnaryOperator>()
                            {
                                new UnaryOperator(UnaryOperatorType.Plus)
                                {
                                    ParameterType = new TypeReference("TestClass"),
                                    ParameterName = "parameter1",
                                    ReturnType = new TypeReference("TestClass"),
                                    Body = new CodeGenerationCollection<Statement>()
                                    {
                                        new ReturnStatement()
                                        {
                                            RawExpression = "parameter1"
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
    public static TestClass operator +(TestClass parameter1)
    {
        return parameter1;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithMinusUnaryOperator()
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
                            UnaryOperators = new CodeGenerationCollection<UnaryOperator>()
                            {
                                new UnaryOperator(UnaryOperatorType.Minus)
                                {
                                    ParameterType = new TypeReference("TestClass"),
                                    ParameterName = "parameter1",
                                    ReturnType = new TypeReference("TestClass"),
                                    Body = new CodeGenerationCollection<Statement>()
                                    {
                                        new ReturnStatement()
                                        {
                                            RawExpression = "parameter1"
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
    public static TestClass operator -(TestClass parameter1)
    {
        return parameter1;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithIncrementUnaryOperator()
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
                            UnaryOperators = new CodeGenerationCollection<UnaryOperator>()
                            {
                                new UnaryOperator(UnaryOperatorType.Increment)
                                {
                                    ParameterType = new TypeReference("TestClass"),
                                    ParameterName = "parameter1",
                                    ReturnType = new TypeReference("TestClass"),
                                    Body = new CodeGenerationCollection<Statement>()
                                    {
                                        new ReturnStatement()
                                        {
                                            RawExpression = "parameter1"
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
    public static TestClass operator ++(TestClass parameter1)
    {
        return parameter1;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithDecrementUnaryOperator()
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
                            UnaryOperators = new CodeGenerationCollection<UnaryOperator>()
                            {
                                new UnaryOperator(UnaryOperatorType.Decrement)
                                {
                                    ParameterType = new TypeReference("TestClass"),
                                    ParameterName = "parameter1",
                                    ReturnType = new TypeReference("TestClass"),
                                    Body = new CodeGenerationCollection<Statement>()
                                    {
                                        new ReturnStatement()
                                        {
                                            RawExpression = "parameter1"
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
    public static TestClass operator --(TestClass parameter1)
    {
        return parameter1;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithLogicalNotUnaryOperator()
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
                            UnaryOperators = new CodeGenerationCollection<UnaryOperator>()
                            {
                                new UnaryOperator(UnaryOperatorType.LogicalNot)
                                {
                                    ParameterType = new TypeReference("TestClass"),
                                    ParameterName = "parameter1",
                                    ReturnType = new TypeReference("TestClass"),
                                    Body = new CodeGenerationCollection<Statement>()
                                    {
                                        new ReturnStatement()
                                        {
                                            RawExpression = "parameter1"
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
    public static TestClass operator !(TestClass parameter1)
    {
        return parameter1;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithBitwiseNotUnaryOperator()
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
                            UnaryOperators = new CodeGenerationCollection<UnaryOperator>()
                            {
                                new UnaryOperator(UnaryOperatorType.BitwiseNot)
                                {
                                    ParameterType = new TypeReference("TestClass"),
                                    ParameterName = "parameter1",
                                    ReturnType = new TypeReference("TestClass"),
                                    Body = new CodeGenerationCollection<Statement>()
                                    {
                                        new ReturnStatement()
                                        {
                                            RawExpression = "parameter1"
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
    public static TestClass operator ~(TestClass parameter1)
    {
        return parameter1;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithTrueUnaryOperator()
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
                            UnaryOperators = new CodeGenerationCollection<UnaryOperator>()
                            {
                                new UnaryOperator(UnaryOperatorType.True)
                                {
                                    ParameterType = new TypeReference("TestClass"),
                                    ParameterName = "parameter1",
                                    Body = new CodeGenerationCollection<Statement>()
                                    {
                                        new ReturnStatement()
                                        {
                                            RawExpression = "true"
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
    public static bool operator true(TestClass parameter1)
    {
        return true;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithFalseUnaryOperator()
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
                            UnaryOperators = new CodeGenerationCollection<UnaryOperator>()
                            {
                                new UnaryOperator(UnaryOperatorType.False)
                                {
                                    ParameterType = new TypeReference("TestClass"),
                                    ParameterName = "parameter1",
                                    Body = new CodeGenerationCollection<Statement>()
                                    {
                                        new ReturnStatement()
                                        {
                                            RawExpression = "false"
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
    public static bool operator false(TestClass parameter1)
    {
        return false;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
