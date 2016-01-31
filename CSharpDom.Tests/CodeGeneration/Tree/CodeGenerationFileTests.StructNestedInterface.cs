using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestStructNestedInterface()
        {
            const string expectedText = @"struct TestStruct
{
    interface ITestStructNestedInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedInterfaces = new Collection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicStructNestedInterface()
        {
            const string expectedText = @"struct TestStruct
{
    public interface ITestStructNestedInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedInterfaces = new Collection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalStructNestedInterface()
        {
            const string expectedText = @"struct TestStruct
{
    internal interface ITestStructNestedInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedInterfaces = new Collection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
                                {
                                    Visibility = StructMemberVisibilityModifier.Internal
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestPrivateStructNestedInterface()
        {
            const string expectedText = @"struct TestStruct
{
    private interface ITestStructNestedInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedInterfaces = new Collection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
                                {
                                    Visibility = StructMemberVisibilityModifier.Private
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWith1GenericParameter()
        {
            const string expectedText = @"struct TestStruct
{
    interface ITestStructNestedInterface<T>
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedInterfaces = new Collection<StructNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWith2GenericParameters()
        {
            const string expectedText = @"struct TestStruct
{
    interface ITestStructNestedInterface<TKey, TValue>
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedInterfaces = new Collection<StructNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWithClassGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    interface ITestStructNestedInterface<T>
        where T : class
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedInterfaces = new Collection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                        {
                                            TypeConstraint = GenericParameterTypeConstraint.Class
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWithStructGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    interface ITestStructNestedInterface<T>
        where T : struct
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedInterfaces = new Collection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                        {
                                            TypeConstraint = GenericParameterTypeConstraint.Struct
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWithEmptyConstructorGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    interface ITestStructNestedInterface<T>
        where T : new()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedInterfaces = new Collection<StructNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWithBaseClassGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    interface ITestStructNestedInterface<T>
        where T : BaseClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedInterfaces = new Collection<StructNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWith1StructNestedInterfaceGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    interface ITestStructNestedInterface<T>
        where T : ITestInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedInterfaces = new Collection<StructNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWith2StructNestedInterfaceGenericParameterConstraints()
        {
            const string expectedText = @"struct TestStruct
{
    interface ITestStructNestedInterface<T>
        where T : ITestInterface, ITestInterface2
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedInterfaces = new Collection<StructNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWith1GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    interface ITestStructNestedInterface<TParent, TChild>
        where TChild : TParent
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedInterfaces = new Collection<StructNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWith2GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    interface ITestStructNestedInterface<TGrandparent, TParent, TChild>
        where TChild : TGrandparent, TParent
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedInterfaces = new Collection<StructNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWithStructAndStructNestedInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            const string expectedText = @"struct TestStruct
{
    interface ITestStructNestedInterface<T>
        where T : struct, ITestInterface, new()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedInterfaces = new Collection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                        {
                                            TypeConstraint = GenericParameterTypeConstraint.Struct,
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWith2GenericParameterConstraints()
        {
            const string expectedText = @"struct TestStruct
{
    interface ITestStructNestedInterface<TKey, TValue>
        where TKey : ITestInterface
        where TValue : TKey
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedInterfaces = new Collection<StructNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructNestedInterfaceWithInterface()
        {
            const string expectedText = @"struct TestStruct
{
    interface ITestStructNestedInterface : ITestInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedInterfaces = new Collection<StructNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedInterfaceWith2StructNestedInterfaces()
        {
            const string expectedText = @"struct TestStruct
{
    interface ITestStructNestedInterface : ITestInterface, ITestInterface2
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedInterfaces = new Collection<StructNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPartialStructNestedInterface()
        {
            const string expectedText = @"struct TestStruct
{
    partial interface ITestStructNestedInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedInterfaces = new Collection<StructNestedInterface>()
                            {
                                new StructNestedInterface("ITestStructNestedInterface")
                                {
                                    IsPartial = true
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
    }
}
