using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestStructNestedEnum()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new CodeGenerationCollection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    enum TestStructNestedEnum
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicStructNestedEnum()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new CodeGenerationCollection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    public enum TestStructNestedEnum
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalStructNestedEnum()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new CodeGenerationCollection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    Visibility = StructMemberVisibilityModifier.Internal
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    internal enum TestStructNestedEnum
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestPrivateStructNestedEnum()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new CodeGenerationCollection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    Visibility = StructMemberVisibilityModifier.Private
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    private enum TestStructNestedEnum
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedEnumWithByteBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new CodeGenerationCollection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    BaseType = EnumBaseType.Byte
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    enum TestStructNestedEnum : byte
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedEnumWithSByteBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {

                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new CodeGenerationCollection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    BaseType = EnumBaseType.SByte
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    enum TestStructNestedEnum : sbyte
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedEnumWithShortBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new CodeGenerationCollection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    BaseType = EnumBaseType.Short
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    enum TestStructNestedEnum : short
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedEnumWithUShortBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new CodeGenerationCollection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    BaseType = EnumBaseType.UShort
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    enum TestStructNestedEnum : ushort
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedEnumWithIntBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new CodeGenerationCollection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    BaseType = EnumBaseType.Int
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    enum TestStructNestedEnum : int
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedEnumWithUIntBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new CodeGenerationCollection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    BaseType = EnumBaseType.UInt
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    enum TestStructNestedEnum : uint
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedEnumWithLongBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new CodeGenerationCollection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    BaseType = EnumBaseType.Long
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    enum TestStructNestedEnum : long
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedEnumWithULongBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new CodeGenerationCollection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    BaseType = EnumBaseType.ULong
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    enum TestStructNestedEnum : ulong
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
