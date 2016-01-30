using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestClassWithPlusBinaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static TestClass operator +(TestClass parameter1, TestClass parameter2)
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
                            BinaryOperators = new Collection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.Plus)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
        public void TestClassWithMinusBinaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static TestClass operator -(TestClass parameter1, TestClass parameter2)
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
                            BinaryOperators = new Collection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.Minus)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
        public void TestClassWithMultiplyBinaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static TestClass operator *(TestClass parameter1, TestClass parameter2)
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
                            BinaryOperators = new Collection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.Multiply)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
        public void TestClassWithDivideBinaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static TestClass operator /(TestClass parameter1, TestClass parameter2)
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
                            BinaryOperators = new Collection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.Divide)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
        public void TestClassWithModuloBinaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static TestClass operator %(TestClass parameter1, TestClass parameter2)
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
                            BinaryOperators = new Collection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.Modulo)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
        public void TestClassWithAndBinaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static TestClass operator &(TestClass parameter1, TestClass parameter2)
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
                            BinaryOperators = new Collection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.And)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
        public void TestClassWithOrBinaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static TestClass operator |(TestClass parameter1, TestClass parameter2)
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
                            BinaryOperators = new Collection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.Or)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
        public void TestClassWithExclusiveOrBinaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static TestClass operator ^(TestClass parameter1, TestClass parameter2)
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
                            BinaryOperators = new Collection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.ExclusiveOr)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
        public void TestClassWithLeftShiftBinaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static TestClass operator <<(TestClass parameter1, TestClass parameter2)
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
                            BinaryOperators = new Collection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.LeftShift)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
        public void TestClassWithRightShiftBinaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static TestClass operator >>(TestClass parameter1, TestClass parameter2)
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
                            BinaryOperators = new Collection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.RightShift)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
        public void TestClassWithEqualBinaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static bool operator ==(TestClass parameter1, TestClass parameter2)
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
                            BinaryOperators = new Collection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.Equal)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
        public void TestClassWithNotEqualBinaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static bool operator !=(TestClass parameter1, TestClass parameter2)
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
                            BinaryOperators = new Collection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.NotEqual)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
        public void TestClassWithGreaterThanBinaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static bool operator >(TestClass parameter1, TestClass parameter2)
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
                            BinaryOperators = new Collection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.GreaterThan)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
        public void TestClassWithGreaterThanOrEqualBinaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static bool operator >=(TestClass parameter1, TestClass parameter2)
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
                            BinaryOperators = new Collection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.GreaterThanOrEqual)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
        public void TestClassWithLessThanBinaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static bool operator <(TestClass parameter1, TestClass parameter2)
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
                            BinaryOperators = new Collection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.LessThan)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
        public void TestClassWithLessThanOrEqualBinaryOperator()
        {
            const string expectedText = @"class TestClass
{
    public static bool operator <=(TestClass parameter1, TestClass parameter2)
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
                            BinaryOperators = new Collection<BinaryOperator>()
                            {
                                new BinaryOperator(BinaryOperatorType.LessThanOrEqual)
                                {
                                    Parameter1Type = new TypeReference("TestClass"),
                                    Parameter1Name = "parameter1",
                                    Parameter2Type = new TypeReference("TestClass"),
                                    Parameter2Name = "parameter2",
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
    }
}
