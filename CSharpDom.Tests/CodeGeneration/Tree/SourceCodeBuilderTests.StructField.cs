using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestStructWithField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Fields =
                            {
                                new StructFieldDeclaration(new TypeReference("string"))
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
            const string expectedText = @"struct TestStruct
{
    string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith2Fields()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Fields =
                            {
                                new StructFieldDeclaration(new TypeReference("string"))
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
            const string expectedText = @"struct TestStruct
{
    string field1, field2;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith2FieldDeclarations()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Fields =
                            {
                                new StructFieldDeclaration(new TypeReference("string"))
                                {
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                },
                                new StructFieldDeclaration(new TypeReference("string"))
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
            const string expectedText = @"struct TestStruct
{
    string field1;
    string field2;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Fields =
                            {
                                new StructFieldDeclaration(new TypeReference("string"))
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
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
            const string expectedText = @"struct TestStruct
{
    public string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithInternalField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Fields =
                            {
                                new StructFieldDeclaration(new TypeReference("string"))
                                {
                                    Visibility = StructMemberVisibilityModifier.Internal,
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
            const string expectedText = @"struct TestStruct
{
    internal string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithPrivateField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Fields =
                            {
                                new StructFieldDeclaration(new TypeReference("string"))
                                {
                                    Visibility = StructMemberVisibilityModifier.Private,
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
            const string expectedText = @"struct TestStruct
{
    private string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicConstField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Fields =
                            {
                                new StructFieldDeclaration(new TypeReference("string"))
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
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
            const string expectedText = @"struct TestStruct
{
    public const string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicStaticField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Fields =
                            {
                                new StructFieldDeclaration(new TypeReference("string"))
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
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
            const string expectedText = @"struct TestStruct
{
    public static string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicReadOnlyField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Fields =
                            {
                                new StructFieldDeclaration(new TypeReference("string"))
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
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
            const string expectedText = @"struct TestStruct
{
    public readonly string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicStaticReadOnlyField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Fields =
                            {
                                new StructFieldDeclaration(new TypeReference("string"))
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
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
            const string expectedText = @"struct TestStruct
{
    public static readonly string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicVolatileField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Fields =
                            {
                                new StructFieldDeclaration(new TypeReference("string"))
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
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
            const string expectedText = @"struct TestStruct
{
    public volatile string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicStaticVolatileField()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Fields =
                            {
                                new StructFieldDeclaration(new TypeReference("string"))
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
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
            const string expectedText = @"struct TestStruct
{
    public static volatile string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
