using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestClassWithPlusUnaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static TestClass operator +(TestClass parameter1)
    {
        return parameter1;
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
                            UnaryOperators = new Collection<UnaryOperator>()
                            {
                                new UnaryOperator(UnaryOperatorType.Plus)
                                {
                                    ParameterType = new TypeReference("TestClass"),
                                    ParameterName = "parameter1",
                                    ReturnType = new TypeReference("TestClass"),
                                    Body = new Collection<Statement>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithMinusUnaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static TestClass operator -(TestClass parameter1)
    {
        return parameter1;
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
                            UnaryOperators = new Collection<UnaryOperator>()
                            {
                                new UnaryOperator(UnaryOperatorType.Minus)
                                {
                                    ParameterType = new TypeReference("TestClass"),
                                    ParameterName = "parameter1",
                                    ReturnType = new TypeReference("TestClass"),
                                    Body = new Collection<Statement>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithIncrementUnaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static TestClass operator ++(TestClass parameter1)
    {
        return parameter1;
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
                            UnaryOperators = new Collection<UnaryOperator>()
                            {
                                new UnaryOperator(UnaryOperatorType.Increment)
                                {
                                    ParameterType = new TypeReference("TestClass"),
                                    ParameterName = "parameter1",
                                    ReturnType = new TypeReference("TestClass"),
                                    Body = new Collection<Statement>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithDecrementUnaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static TestClass operator --(TestClass parameter1)
    {
        return parameter1;
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
                            UnaryOperators = new Collection<UnaryOperator>()
                            {
                                new UnaryOperator(UnaryOperatorType.Decrement)
                                {
                                    ParameterType = new TypeReference("TestClass"),
                                    ParameterName = "parameter1",
                                    ReturnType = new TypeReference("TestClass"),
                                    Body = new Collection<Statement>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithLogicalNotUnaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static TestClass operator !(TestClass parameter1)
    {
        return parameter1;
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
                            UnaryOperators = new Collection<UnaryOperator>()
                            {
                                new UnaryOperator(UnaryOperatorType.LogicalNot)
                                {
                                    ParameterType = new TypeReference("TestClass"),
                                    ParameterName = "parameter1",
                                    ReturnType = new TypeReference("TestClass"),
                                    Body = new Collection<Statement>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithBitwiseNotUnaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static TestClass operator ~(TestClass parameter1)
    {
        return parameter1;
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
                            UnaryOperators = new Collection<UnaryOperator>()
                            {
                                new UnaryOperator(UnaryOperatorType.BitwiseNot)
                                {
                                    ParameterType = new TypeReference("TestClass"),
                                    ParameterName = "parameter1",
                                    ReturnType = new TypeReference("TestClass"),
                                    Body = new Collection<Statement>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithTrueUnaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static bool operator true(TestClass parameter1)
    {
        return true;
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
                            UnaryOperators = new Collection<UnaryOperator>()
                            {
                                new UnaryOperator(UnaryOperatorType.True)
                                {
                                    ParameterType = new TypeReference("TestClass"),
                                    ParameterName = "parameter1",
                                    Body = new Collection<Statement>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithFalseUnaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static bool operator false(TestClass parameter1)
    {
        return false;
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
                            UnaryOperators = new Collection<UnaryOperator>()
                            {
                                new UnaryOperator(UnaryOperatorType.False)
                                {
                                    ParameterType = new TypeReference("TestClass"),
                                    ParameterName = "parameter1",
                                    Body = new Collection<Statement>()
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
            }).ToString().Should().Be(expectedText);
        }
    }
}
