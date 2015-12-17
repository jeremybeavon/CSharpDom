using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestStructNestedInterface()
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
                            NestedInterfaces = new CodeGenerationCollection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    interface ITestStructNestedInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicStructNestedInterface()
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
                            NestedInterfaces = new CodeGenerationCollection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
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
    public interface ITestStructNestedInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalStructNestedInterface()
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
                            NestedInterfaces = new CodeGenerationCollection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
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
    internal interface ITestStructNestedInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestPrivateStructNestedInterface()
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
                            NestedInterfaces = new CodeGenerationCollection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
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
    private interface ITestStructNestedInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWith1GenericParameter()
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
                            NestedInterfaces = new CodeGenerationCollection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
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
    interface ITestStructNestedInterface<T>
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWith2GenericParameters()
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
                            NestedInterfaces = new CodeGenerationCollection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
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
    interface ITestStructNestedInterface<TKey, TValue>
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWithClassGenericParameterConstraint()
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
                            NestedInterfaces = new CodeGenerationCollection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
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
    interface ITestStructNestedInterface<T>
        where T : class
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWithStructGenericParameterConstraint()
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
                            NestedInterfaces = new CodeGenerationCollection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
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
    interface ITestStructNestedInterface<T>
        where T : struct
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWithEmptyConstructorGenericParameterConstraint()
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
                            NestedInterfaces = new CodeGenerationCollection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
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
    interface ITestStructNestedInterface<T>
        where T : new()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWithBaseClassGenericParameterConstraint()
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
                            NestedInterfaces = new CodeGenerationCollection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
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
    interface ITestStructNestedInterface<T>
        where T : BaseClass
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWith1StructNestedInterfaceGenericParameterConstraint()
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
                            NestedInterfaces = new CodeGenerationCollection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
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
    interface ITestStructNestedInterface<T>
        where T : ITestInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWith2StructNestedInterfaceGenericParameterConstraints()
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
                            NestedInterfaces = new CodeGenerationCollection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
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
    interface ITestStructNestedInterface<T>
        where T : ITestInterface, ITestInterface2
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWith1GenericTypeGenericParameterConstraint()
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
                            NestedInterfaces = new CodeGenerationCollection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
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
    interface ITestStructNestedInterface<TParent, TChild>
        where TChild : TParent
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWith2GenericTypeGenericParameterConstraint()
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
                            NestedInterfaces = new CodeGenerationCollection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
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
    interface ITestStructNestedInterface<TGrandparent, TParent, TChild>
        where TChild : TGrandparent, TParent
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWithStructAndStructNestedInterfaceAndEmptyConstructorGenericParameterConstraints()
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
                            NestedInterfaces = new CodeGenerationCollection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
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
    interface ITestStructNestedInterface<T>
        where T : struct, ITestInterface, new()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWith2GenericParameterConstraints()
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
                            NestedInterfaces = new CodeGenerationCollection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
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
    interface ITestStructNestedInterface<TKey, TValue>
        where TKey : ITestInterface
        where TValue : TKey
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructNestedInterfaceWithInterface()
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
                            NestedInterfaces = new CodeGenerationCollection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
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
    interface ITestStructNestedInterface : ITestInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWith2StructNestedInterfaces()
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
                            NestedInterfaces = new CodeGenerationCollection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
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
    interface ITestStructNestedInterface : ITestInterface, ITestInterface2
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPartialStructNestedInterface()
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
                            NestedInterfaces = new CodeGenerationCollection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
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
    partial interface ITestStructNestedInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
