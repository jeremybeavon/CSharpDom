using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestEnumWith1EnumField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        Fields = new CodeGenerationCollection<EnumField>()
                        {
                            new EnumField("Test1")
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"enum TestEnum
{
    Test1
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestEnumWith2EnumFields()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        Fields = new CodeGenerationCollection<EnumField>()
                        {
                            new EnumField("Test1"),
                            new EnumField("Test2")
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"enum TestEnum
{
    Test1,
    Test2
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestEnumWithEnumFieldWithValue()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        Fields = new CodeGenerationCollection<EnumField>()
                        {
                            new EnumField("Test1")
                            {
                                RawInitialValue = "10"
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"enum TestEnum
{
    Test1 = 10
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
