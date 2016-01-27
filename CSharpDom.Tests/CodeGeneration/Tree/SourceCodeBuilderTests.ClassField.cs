using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestClassWithField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
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
                                new ClassFieldDeclaration(new TypeReference("string"))
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
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith2Fields()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
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
                                new ClassFieldDeclaration(new TypeReference("string"))
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
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    string field1, field2;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith2FieldDeclarations()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
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
                                new ClassFieldDeclaration(new TypeReference("string"))
                                {
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                },
                                new ClassFieldDeclaration(new TypeReference("string"))
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
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    string field1;
    string field2;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
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
                                new ClassFieldDeclaration(new TypeReference("string"))
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
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithInternalField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
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
                                new ClassFieldDeclaration(new TypeReference("string"))
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
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    internal string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithProtectedInternalField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
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
                                new ClassFieldDeclaration(new TypeReference("string"))
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
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    protected internal string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithProtectedField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
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
                                new ClassFieldDeclaration(new TypeReference("string"))
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
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    protected string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPrivateField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
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
                                new ClassFieldDeclaration(new TypeReference("string"))
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
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    private string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicConstField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
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
                                new ClassFieldDeclaration(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    Modifier = FieldModifier.Const,
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public const string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicStaticField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
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
                                new ClassFieldDeclaration(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    Modifier = FieldModifier.Static,
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public static string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicReadOnlyField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
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
                                new ClassFieldDeclaration(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    Modifier = FieldModifier.ReadOnly,
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public readonly string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicStaticReadOnlyField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
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
                                new ClassFieldDeclaration(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    Modifier = FieldModifier.StaticReadOnly,
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public static readonly string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicVolatileField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
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
                                new ClassFieldDeclaration(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    Modifier = FieldModifier.Volatile,
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public volatile string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicStaticVolatileField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
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
                                new ClassFieldDeclaration(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    Modifier = FieldModifier.StaticVolatile,
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public static volatile string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
