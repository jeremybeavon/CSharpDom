using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestStructWithIndexer()
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
                            Indexers = new CodeGenerationCollection<StructIndexer>()
                            {
                                new StructIndexer()
                                {
                                    Type = new TypeReference("string"),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(string)))
                                    },
                                    SetAccessor = new StructPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    string this[string parameter1]
    {
        set { }
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith2Indexers()
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
                            Indexers = new CodeGenerationCollection<StructIndexer>()
                            {
                                new StructIndexer()
                                {
                                    Type = new TypeReference("string"),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(string)))
                                    },
                                    SetAccessor = new StructPropertyAccessor()
                                },
                                new StructIndexer()
                                {
                                    Type = new TypeReference("string"),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new StructPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    string this[string parameter1]
    {
        set { }
    }

    string this[int parameter1]
    {
        set { }
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicIndexer()
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
                            Indexers = new CodeGenerationCollection<StructIndexer>()
                            {
                                new StructIndexer()
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
                                    Type = new TypeReference("string"),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new StructPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    public string this[int parameter1]
    {
        set { }
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithInternalIndexer()
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
                            Indexers = new CodeGenerationCollection<StructIndexer>()
                            {
                                new StructIndexer()
                                {
                                    Visibility = StructMemberVisibilityModifier.Internal,
                                    Type = new TypeReference("string"),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new StructPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    internal string this[int parameter1]
    {
        set { }
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithPrivateIndexer()
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
                            Indexers = new CodeGenerationCollection<StructIndexer>()
                            {
                                new StructIndexer()
                                {
                                    Visibility = StructMemberVisibilityModifier.Private,
                                    Type = new TypeReference("string"),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new StructPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    private string this[int parameter1]
    {
        set { }
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
