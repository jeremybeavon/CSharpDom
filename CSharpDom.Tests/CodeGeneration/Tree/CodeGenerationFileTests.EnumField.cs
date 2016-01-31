using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestEnumWith1EnumField()
        {
            const string expectedText = @"enum TestEnum
{
    Test1
}";             
(new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        Fields = new Collection<EnumField>()
                        {
                            new EnumField("Test1")
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestEnumWith2EnumFields()
        {
            const string expectedText = @"enum TestEnum
{
    Test1,
    Test2
}";             
(new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        Fields = new Collection<EnumField>()
                        {
                            new EnumField("Test1"),
                            new EnumField("Test2")
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestEnumWithEnumFieldWithValue()
        {
            const string expectedText = @"enum TestEnum
{
    Test1 = 10
}";             
(new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        Fields = new Collection<EnumField>()
                        {
                            new EnumField("Test1")
                            {
                                RawInitialValue = "10"
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
    }
}
