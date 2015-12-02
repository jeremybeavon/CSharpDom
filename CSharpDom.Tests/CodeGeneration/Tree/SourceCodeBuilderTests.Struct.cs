using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestStruct()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicStruct()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Visibility = TypeVisibilityModifier.Public
                    }
                }
            }).Accept(builder);
            const string expectedText = @"public struct TestStruct
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalStruct()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Visibility = TypeVisibilityModifier.Internal
                    }
                }
            }).Accept(builder);
            const string expectedText = @"internal struct TestStruct
{
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWith1GenericParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct<T>
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith2GenericParameters()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("TKey"),
                            new GenericParameter("TValue")
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct<TKey, TValue>
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithClassGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                TypeConstraint = GenericParameterTypeConstraintModifier.Class
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct<T>
    where T : class
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithStructGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                TypeConstraint = GenericParameterTypeConstraintModifier.Struct
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct<T>
    where T : struct
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithEmptyConstructorGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                HasEmptyConstructorConstraint = true
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct<T>
    where T : new()
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithBaseClassGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                BaseClassConstraint = new ClassReference("BaseClass")
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct<T>
    where T : BaseClass
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith1InterfaceGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                InterfaceConstraints =
                                {
                                    new InterfaceReference("ITestInterface")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct<T>
    where T : ITestInterface
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith2InterfaceGenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                InterfaceConstraints =
                                {
                                    new InterfaceReference("ITestInterface"),
                                    new InterfaceReference("ITestInterface2")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct<T>
    where T : ITestInterface, ITestInterface2
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith1GenericTypeGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("TParent"),
                            new GenericParameter("TChild")
                            {
                                GenericParameterConstraints =
                                {
                                    new GenericParameterReference("TParent")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct<TParent, TChild>
    where TChild : TParent
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith2GenericTypeGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("TGrandparent"),
                            new GenericParameter("TParent"),
                            new GenericParameter("TChild")
                            {
                                GenericParameterConstraints =
                                {
                                    new GenericParameterReference("TGrandparent"),
                                    new GenericParameterReference("TParent")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct<TGrandparent, TParent, TChild>
    where TChild : TGrandparent, TParent
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithStructAndInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                TypeConstraint = GenericParameterTypeConstraintModifier.Struct,
                                InterfaceConstraints =
                                {
                                    new InterfaceReference("ITestInterface")
                                },
                                HasEmptyConstructorConstraint = true
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct<T>
    where T : struct, ITestInterface, new()
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith2GenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("TKey")
                            {
                                InterfaceConstraints =
                                {
                                    new InterfaceReference("ITestInterface")
                                }
                            },
                            new GenericParameter("TValue")
                            {
                                GenericParameterConstraints =
                                {
                                    new GenericParameterReference("TKey")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct<TKey, TValue>
    where TKey : ITestInterface
    where TValue : TKey
{
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithInterface()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Interfaces =
                        {
                            new InterfaceReference("ITestInterface")
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct : ITestInterface
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWith2Interfaces()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Interfaces =
                        {
                            new InterfaceReference("ITestInterface"),
                            new InterfaceReference("ITestInterface2")
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct : ITestInterface, ITestInterface2
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPartialStruct()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        IsPartial = true
                    }
                }
            }).Accept(builder);
            const string expectedText = @"partial struct TestStruct
{
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
