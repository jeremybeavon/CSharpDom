using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestEnum()
        {
            const string expectedText = @"enum TestEnum
{
}";             
(new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicEnum()
        {
            const string expectedText = @"public enum TestEnum
{
}";             
(new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        Visibility = TypeVisibilityModifier.Public
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalEnum()
        {
            const string expectedText = @"internal enum TestEnum
{
}";             
(new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        Visibility = TypeVisibilityModifier.Internal
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestEnumWithByteBaseType()
        {
            const string expectedText = @"enum TestEnum : byte
{
}";             
(new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        BaseType = EnumBaseType.Byte
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestEnumWithSByteBaseType()
        {
            const string expectedText = @"enum TestEnum : sbyte
{
}";             
(new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        BaseType = EnumBaseType.SByte
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestEnumWithShortBaseType()
        {
            const string expectedText = @"enum TestEnum : short
{
}";             
(new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        BaseType = EnumBaseType.Short
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestEnumWithUShortBaseType()
        {
            const string expectedText = @"enum TestEnum : ushort
{
}";             
(new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        BaseType = EnumBaseType.UShort
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestEnumWithIntBaseType()
        {
            const string expectedText = @"enum TestEnum : int
{
}";             
(new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        BaseType = EnumBaseType.Int
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestEnumWithUIntBaseType()
        {
            const string expectedText = @"enum TestEnum : uint
{
}";             
(new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        BaseType = EnumBaseType.UInt
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestEnumWithLongBaseType()
        {
            const string expectedText = @"enum TestEnum : long
{
}";             
(new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        BaseType = EnumBaseType.Long
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestEnumWithULongBaseType()
        {
            const string expectedText = @"enum TestEnum : ulong
{
}";             
(new CodeGenerationFile()
            {
                Enums =
                {
                    new Enum("TestEnum")
                    {
                        BaseType = EnumBaseType.ULong
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
    }
}
