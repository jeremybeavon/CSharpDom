using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestClassNestedEnum()
        {
            const string expectedText = @"class TestClass
{
    enum TestClassNestedEnum
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new Collection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicClassNestedEnum()
        {
            const string expectedText = @"class TestClass
{
    public enum TestClassNestedEnum
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new Collection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalClassNestedEnum()
        {
            const string expectedText = @"class TestClass
{
    internal enum TestClassNestedEnum
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new Collection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Internal
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestProtectedInternalClassNestedEnum()
        {
            const string expectedText = @"class TestClass
{
    protected internal enum TestClassNestedEnum
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new Collection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
                                {
                                    Visibility = ClassMemberVisibilityModifier.ProtectedInternal
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestProtectedClassNestedEnum()
        {
            const string expectedText = @"class TestClass
{
    protected enum TestClassNestedEnum
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new Collection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Protected
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPrivateClassNestedEnum()
        {
            const string expectedText = @"class TestClass
{
    private enum TestClassNestedEnum
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new Collection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Private
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedEnumWithByteBaseType()
        {
            const string expectedText = @"class TestClass
{
    enum TestClassNestedEnum : byte
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new Collection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
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
        public void TestClassNestedEnumWithSByteBaseType()
        {
            const string expectedText = @"class TestClass
{
    enum TestClassNestedEnum : sbyte
    {
    }
}";             
(new CodeGenerationFile()
            {

                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new Collection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
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
        public void TestClassNestedEnumWithShortBaseType()
        {
            const string expectedText = @"class TestClass
{
    enum TestClassNestedEnum : short
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new Collection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
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
        public void TestClassNestedEnumWithUShortBaseType()
        {
            const string expectedText = @"class TestClass
{
    enum TestClassNestedEnum : ushort
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new Collection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
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
        public void TestClassNestedEnumWithIntBaseType()
        {
            const string expectedText = @"class TestClass
{
    enum TestClassNestedEnum : int
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new Collection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
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
        public void TestClassNestedEnumWithUIntBaseType()
        {
            const string expectedText = @"class TestClass
{
    enum TestClassNestedEnum : uint
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new Collection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
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
        public void TestClassNestedEnumWithLongBaseType()
        {
            const string expectedText = @"class TestClass
{
    enum TestClassNestedEnum : long
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new Collection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
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
        public void TestClassNestedEnumWithULongBaseType()
        {
            const string expectedText = @"class TestClass
{
    enum TestClassNestedEnum : ulong
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedEnums = new Collection<ClassNestedEnum>()
                            {
                                new ClassNestedEnum("TestClassNestedEnum")
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
