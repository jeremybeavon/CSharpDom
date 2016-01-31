using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestStructNestedEnum()
        {
            const string expectedText = @"struct TestStruct
{
    enum TestStructNestedEnum
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new Collection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicStructNestedEnum()
        {
            const string expectedText = @"struct TestStruct
{
    public enum TestStructNestedEnum
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new Collection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalStructNestedEnum()
        {
            const string expectedText = @"struct TestStruct
{
    internal enum TestStructNestedEnum
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new Collection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    Visibility = StructMemberVisibilityModifier.Internal
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestPrivateStructNestedEnum()
        {
            const string expectedText = @"struct TestStruct
{
    private enum TestStructNestedEnum
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new Collection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    Visibility = StructMemberVisibilityModifier.Private
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedEnumWithByteBaseType()
        {
            const string expectedText = @"struct TestStruct
{
    enum TestStructNestedEnum : byte
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new Collection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    BaseType = EnumBaseType.Byte
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedEnumWithSByteBaseType()
        {
            const string expectedText = @"struct TestStruct
{
    enum TestStructNestedEnum : sbyte
    {
    }
}";             
(new CodeGenerationFile()
            {

                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new Collection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    BaseType = EnumBaseType.SByte
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedEnumWithShortBaseType()
        {
            const string expectedText = @"struct TestStruct
{
    enum TestStructNestedEnum : short
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new Collection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    BaseType = EnumBaseType.Short
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedEnumWithUShortBaseType()
        {
            const string expectedText = @"struct TestStruct
{
    enum TestStructNestedEnum : ushort
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new Collection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    BaseType = EnumBaseType.UShort
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedEnumWithIntBaseType()
        {
            const string expectedText = @"struct TestStruct
{
    enum TestStructNestedEnum : int
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new Collection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    BaseType = EnumBaseType.Int
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedEnumWithUIntBaseType()
        {
            const string expectedText = @"struct TestStruct
{
    enum TestStructNestedEnum : uint
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new Collection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    BaseType = EnumBaseType.UInt
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedEnumWithLongBaseType()
        {
            const string expectedText = @"struct TestStruct
{
    enum TestStructNestedEnum : long
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new Collection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    BaseType = EnumBaseType.Long
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedEnumWithULongBaseType()
        {
            const string expectedText = @"struct TestStruct
{
    enum TestStructNestedEnum : ulong
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedEnums = new Collection<StructNestedEnum>()
                            {
                                new StructNestedEnum("TestStructNestedEnum")
                                {
                                    BaseType = EnumBaseType.ULong
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
    }
}
