using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestEnum()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                }
            }).Accept(builder);
            const string expectedText = @"enum TestEnum
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicEnum()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        Visibility = TypeVisibilityModifier.Public
                    }
                }
            }).Accept(builder);
            const string expectedText = @"public enum TestEnum
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalEnum()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        Visibility = TypeVisibilityModifier.Internal
                    }
                }
            }).Accept(builder);
            const string expectedText = @"internal enum TestEnum
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestEnumWithByteBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        BaseType = EnumBaseType.Byte
                    }
                }
            }).Accept(builder);
            const string expectedText = @"enum TestEnum : byte
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestEnumWithSByteBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        BaseType = EnumBaseType.SByte
                    }
                }
            }).Accept(builder);
            const string expectedText = @"enum TestEnum : sbyte
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestEnumWithShortBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        BaseType = EnumBaseType.Short
                    }
                }
            }).Accept(builder);
            const string expectedText = @"enum TestEnum : short
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestEnumWithUShortBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        BaseType = EnumBaseType.UShort
                    }
                }
            }).Accept(builder);
            const string expectedText = @"enum TestEnum : ushort
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestEnumWithIntBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        BaseType = EnumBaseType.Int
                    }
                }
            }).Accept(builder);
            const string expectedText = @"enum TestEnum : int
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestEnumWithUIntBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        BaseType = EnumBaseType.UInt
                    }
                }
            }).Accept(builder);
            const string expectedText = @"enum TestEnum : uint
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestEnumWithLongBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        BaseType = EnumBaseType.Long
                    }
                }
            }).Accept(builder);
            const string expectedText = @"enum TestEnum : long
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestEnumWithULongBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        BaseType = EnumBaseType.ULong
                    }
                }
            }).Accept(builder);
            const string expectedText = @"enum TestEnum : ulong
{
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
