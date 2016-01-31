using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestStructWithIndexer()
        {
            const string expectedText = @"struct TestStruct
{
    string this[string parameter1]
    {
        set { }
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Indexers = new Collection<StructIndexer>()
                            {
                                new StructIndexer()
                                {
                                    Type = new TypeReference("string"),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(string)))
                                    },
                                    SetAccessor = new StructPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith2Indexers()
        {
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
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Indexers = new Collection<StructIndexer>()
                            {
                                new StructIndexer()
                                {
                                    Type = new TypeReference("string"),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(string)))
                                    },
                                    SetAccessor = new StructPropertyAccessor()
                                },
                                new StructIndexer()
                                {
                                    Type = new TypeReference("string"),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new StructPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicIndexer()
        {
            const string expectedText = @"struct TestStruct
{
    public string this[int parameter1]
    {
        set { }
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Indexers = new Collection<StructIndexer>()
                            {
                                new StructIndexer()
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
                                    Type = new TypeReference("string"),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new StructPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithInternalIndexer()
        {
            const string expectedText = @"struct TestStruct
{
    internal string this[int parameter1]
    {
        set { }
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Indexers = new Collection<StructIndexer>()
                            {
                                new StructIndexer()
                                {
                                    Visibility = StructMemberVisibilityModifier.Internal,
                                    Type = new TypeReference("string"),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new StructPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithPrivateIndexer()
        {
            const string expectedText = @"struct TestStruct
{
    private string this[int parameter1]
    {
        set { }
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Indexers = new Collection<StructIndexer>()
                            {
                                new StructIndexer()
                                {
                                    Visibility = StructMemberVisibilityModifier.Private,
                                    Type = new TypeReference("string"),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new StructPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
    }
}
