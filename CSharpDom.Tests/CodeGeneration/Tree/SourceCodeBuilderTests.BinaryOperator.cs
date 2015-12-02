using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestClassWithPlusBinaryOperator()
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
                            BinaryOperators = new CodeGenerationCollection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.Plus)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
    public static TestClass operator +(TestClass parameter1, TestClass parameter2)
    {
        return parameter1;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithMinusBinaryOperator()
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
                            BinaryOperators = new CodeGenerationCollection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.Minus)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
    public static TestClass operator -(TestClass parameter1, TestClass parameter2)
    {
        return parameter1;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithMultiplyBinaryOperator()
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
                            BinaryOperators = new CodeGenerationCollection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.Multiply)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
    public static TestClass operator *(TestClass parameter1, TestClass parameter2)
    {
        return parameter1;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithDivideBinaryOperator()
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
                            BinaryOperators = new CodeGenerationCollection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.Divide)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
    public static TestClass operator /(TestClass parameter1, TestClass parameter2)
    {
        return parameter1;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithModuloBinaryOperator()
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
                            BinaryOperators = new CodeGenerationCollection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.Modulo)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
    public static TestClass operator %(TestClass parameter1, TestClass parameter2)
    {
        return parameter1;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithAndBinaryOperator()
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
                            BinaryOperators = new CodeGenerationCollection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.And)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
    public static TestClass operator &(TestClass parameter1, TestClass parameter2)
    {
        return parameter1;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithOrBinaryOperator()
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
                            BinaryOperators = new CodeGenerationCollection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.Or)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
    public static TestClass operator |(TestClass parameter1, TestClass parameter2)
    {
        return parameter1;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithExclusiveOrBinaryOperator()
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
                            BinaryOperators = new CodeGenerationCollection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.ExclusiveOr)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
    public static TestClass operator ^(TestClass parameter1, TestClass parameter2)
    {
        return parameter1;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithLeftShiftBinaryOperator()
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
                            BinaryOperators = new CodeGenerationCollection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.LeftShift)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
    public static TestClass operator <<(TestClass parameter1, TestClass parameter2)
    {
        return parameter1;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithRightShiftBinaryOperator()
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
                            BinaryOperators = new CodeGenerationCollection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.RightShift)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
    public static TestClass operator >>(TestClass parameter1, TestClass parameter2)
    {
        return parameter1;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithEqualBinaryOperator()
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
                            BinaryOperators = new CodeGenerationCollection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.Equal)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
    public static bool operator ==(TestClass parameter1, TestClass parameter2)
    {
        return true;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithNotEqualBinaryOperator()
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
                            BinaryOperators = new CodeGenerationCollection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.NotEqual)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
    public static bool operator !=(TestClass parameter1, TestClass parameter2)
    {
        return true;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithGreaterThanBinaryOperator()
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
                            BinaryOperators = new CodeGenerationCollection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.GreaterThan)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
    public static bool operator >(TestClass parameter1, TestClass parameter2)
    {
        return true;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithGreaterThanOrEqualBinaryOperator()
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
                            BinaryOperators = new CodeGenerationCollection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.GreaterThanOrEqual)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
    public static bool operator >=(TestClass parameter1, TestClass parameter2)
    {
        return true;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithLessThanBinaryOperator()
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
                            BinaryOperators = new CodeGenerationCollection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.LessThan)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
    public static bool operator <(TestClass parameter1, TestClass parameter2)
    {
        return true;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithLessThanOrEqualBinaryOperator()
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
                            BinaryOperators = new CodeGenerationCollection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.LessThanOrEqual)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
    public static bool operator <=(TestClass parameter1, TestClass parameter2)
    {
        return true;
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
