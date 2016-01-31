using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestStructWithField()
        {
            const string expectedText = @"struct TestStruct
{
    string field1;
}";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith2Fields()
        {
            const string expectedText = @"struct TestStruct
{
    string field1, field2;
}";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith2FieldDeclarations()
        {
            const string expectedText = @"struct TestStruct
{
    string field1;
    string field2;
}";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicField()
        {
            const string expectedText = @"struct TestStruct
{
    public string field1;
}";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithInternalField()
        {
            const string expectedText = @"struct TestStruct
{
    internal string field1;
}";             
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
            }).ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithPrivateField()
        {
            const string expectedText = @"struct TestStruct
{
    private string field1;
}";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicConstField()
        {
            const string expectedText = @"struct TestStruct
{
    public const string field1;
}";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicStaticField()
        {
            const string expectedText = @"struct TestStruct
{
    public static string field1;
}";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicReadOnlyField()
        {
            const string expectedText = @"struct TestStruct
{
    public readonly string field1;
}";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicStaticReadOnlyField()
        {
            const string expectedText = @"struct TestStruct
{
    public static readonly string field1;
}";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicVolatileField()
        {
            const string expectedText = @"struct TestStruct
{
    public volatile string field1;
}";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicStaticVolatileField()
        {
            const string expectedText = @"struct TestStruct
{
    public static volatile string field1;
}";             
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
            }).ToString().Should().Be(expectedText);
        }
    }
}
