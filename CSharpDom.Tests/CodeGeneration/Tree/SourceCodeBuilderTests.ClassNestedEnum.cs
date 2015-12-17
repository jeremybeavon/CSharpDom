using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestClassNestedEnum()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new CodeGenerationCollection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    enum TestClassNestedEnum
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicClassNestedEnum()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new CodeGenerationCollection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public enum TestClassNestedEnum
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalClassNestedEnum()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new CodeGenerationCollection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Internal
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    internal enum TestClassNestedEnum
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestProtectedInternalClassNestedEnum()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new CodeGenerationCollection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
                                {
                                    Visibility = ClassMemberVisibilityModifier.ProtectedInternal
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    protected internal enum TestClassNestedEnum
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestProtectedClassNestedEnum()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new CodeGenerationCollection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Protected
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    protected enum TestClassNestedEnum
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPrivateClassNestedEnum()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new CodeGenerationCollection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Private
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    private enum TestClassNestedEnum
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedEnumWithByteBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new CodeGenerationCollection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
                                {
                                    BaseType = EnumBaseType.Byte
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    enum TestClassNestedEnum : byte
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedEnumWithSByteBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {

                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new CodeGenerationCollection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
                                {
                                    BaseType = EnumBaseType.SByte
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    enum TestClassNestedEnum : sbyte
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedEnumWithShortBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new CodeGenerationCollection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
                                {
                                    BaseType = EnumBaseType.Short
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    enum TestClassNestedEnum : short
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedEnumWithUShortBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new CodeGenerationCollection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
                                {
                                    BaseType = EnumBaseType.UShort
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    enum TestClassNestedEnum : ushort
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedEnumWithIntBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new CodeGenerationCollection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
                                {
                                    BaseType = EnumBaseType.Int
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    enum TestClassNestedEnum : int
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedEnumWithUIntBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new CodeGenerationCollection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
                                {
                                    BaseType = EnumBaseType.UInt
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    enum TestClassNestedEnum : uint
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedEnumWithLongBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new CodeGenerationCollection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
                                {
                                    BaseType = EnumBaseType.Long
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    enum TestClassNestedEnum : long
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedEnumWithULongBaseType()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new CodeGenerationCollection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
                                {
                                    BaseType = EnumBaseType.ULong
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    enum TestClassNestedEnum : ulong
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
