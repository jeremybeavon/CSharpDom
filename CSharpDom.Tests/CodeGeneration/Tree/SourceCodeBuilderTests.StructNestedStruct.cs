using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestStructNestedStruct()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new CodeGenerationCollection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicStructNestedStruct()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new CodeGenerationCollection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    public struct TestStructNestedStruct
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalStructNestedStruct()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new CodeGenerationCollection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
                                {
                                    Visibility = StructMemberVisibilityModifier.Internal
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    internal struct TestStructNestedStruct
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestPrivateStructNestedStruct()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new CodeGenerationCollection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
                                {
                                    Visibility = StructMemberVisibilityModifier.Private
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    private struct TestStructNestedStruct
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWith1GenericParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new CodeGenerationCollection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<T>
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWith2GenericParameters()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new CodeGenerationCollection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("TKey"),
                                        new GenericParameter("TValue")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<TKey, TValue>
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWithClassGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new CodeGenerationCollection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<T>
        where T : class
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWithStructGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new CodeGenerationCollection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<T>
        where T : struct
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWithEmptyConstructorGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new CodeGenerationCollection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<T>
        where T : new()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWithBaseClassGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new CodeGenerationCollection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<T>
        where T : BaseClass
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWith1InterfaceGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new CodeGenerationCollection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<T>
        where T : ITestInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWith2InterfaceGenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new CodeGenerationCollection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<T>
        where T : ITestInterface, ITestInterface2
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWith1GenericTypeGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new CodeGenerationCollection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<TParent, TChild>
        where TChild : TParent
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWith2GenericTypeGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new CodeGenerationCollection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<TGrandparent, TParent, TChild>
        where TChild : TGrandparent, TParent
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWithStructAndInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new CodeGenerationCollection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<T>
        where T : struct, ITestInterface, new()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWith2GenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new CodeGenerationCollection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct<TKey, TValue>
        where TKey : ITestInterface
        where TValue : TKey
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructNestedStructWithInterface()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new CodeGenerationCollection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
                                {
                                    Interfaces =
                                    {
                                        new InterfaceReference("ITestInterface")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct : ITestInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedStructWith2Interfaces()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new CodeGenerationCollection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
                                {
                                    Interfaces =
                                    {
                                        new InterfaceReference("ITestInterface"),
                                        new InterfaceReference("ITestInterface2")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    struct TestStructNestedStruct : ITestInterface, ITestInterface2
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPartialStructNestedStruct()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedStructs = new CodeGenerationCollection<StructNestedStruct>()
                            {
                                new StructNestedStruct("TestStructNestedStruct")
                                {
                                    IsPartial = true
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    partial struct TestStructNestedStruct
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
