using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestClassWithField()
        {
            const string expectedText = @"class TestClass
{
    string field1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Fields =
                            {
                                new ClassField(new TypeReference("string"))
                                {
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith2Fields()
        {
            const string expectedText = @"class TestClass
{
    string field1, field2;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Fields =
                            {
                                new ClassField(new TypeReference("string"))
                                {
                                    Fields =
                                    {
                                        new Field("field1"),
                                        new Field("field2")
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith2FieldDeclarations()
        {
            const string expectedText = @"class TestClass
{
    string field1;
    string field2;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Fields =
                            {
                                new ClassField(new TypeReference("string"))
                                {
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                },
                                new ClassField(new TypeReference("string"))
                                {
                                    Fields =
                                    {
                                        new Field("field2")
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicField()
        {
            const string expectedText = @"class TestClass
{
    public string field1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Fields =
                            {
                                new ClassField(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithInternalField()
        {
            const string expectedText = @"class TestClass
{
    internal string field1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Fields =
                            {
                                new ClassField(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.Internal,
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithProtectedInternalField()
        {
            const string expectedText = @"class TestClass
{
    protected internal string field1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Fields =
                            {
                                new ClassField(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.ProtectedInternal,
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithProtectedField()
        {
            const string expectedText = @"class TestClass
{
    protected string field1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Fields =
                            {
                                new ClassField(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.Protected,
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPrivateField()
        {
            const string expectedText = @"class TestClass
{
    private string field1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Fields =
                            {
                                new ClassField(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.Private,
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        /*[TestMethod]
        public void TestClassWithPublicConstField()
        {
            const string expectedText = @"class TestClass
{
    public const string field1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Fields =
                            {
                                new ClassField(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    Modifier = ClassFieldModifier.Const,
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }*/

        [TestMethod]
        public void TestClassWithPublicStaticField()
        {
            const string expectedText = @"class TestClass
{
    public static string field1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Fields =
                            {
                                new ClassField(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    Modifier = ClassFieldModifier.Static,
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicReadOnlyField()
        {
            const string expectedText = @"class TestClass
{
    public readonly string field1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Fields =
                            {
                                new ClassField(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    Modifier = ClassFieldModifier.ReadOnly,
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicStaticReadOnlyField()
        {
            const string expectedText = @"class TestClass
{
    public static readonly string field1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Fields =
                            {
                                new ClassField(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    Modifier = ClassFieldModifier.StaticReadOnly,
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicVolatileField()
        {
            const string expectedText = @"class TestClass
{
    public volatile string field1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Fields =
                            {
                                new ClassField(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    Modifier = ClassFieldModifier.Volatile,
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicStaticVolatileField()
        {
            const string expectedText = @"class TestClass
{
    public static volatile string field1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Fields =
                            {
                                new ClassField(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    Modifier = ClassFieldModifier.StaticVolatile,
                                    Fields =
                                    {
                                        new Field("field1")
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
