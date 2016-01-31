using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestStructNestedDelegate()
        {
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate();
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new Collection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicStructNestedDelegate()
        {
            const string expectedText = @"struct TestStruct
{
    public delegate string TestStructNestedDelegate();
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new Collection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
                                    ReturnType = new TypeReference(typeof(string))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalStructNestedDelegate()
        {
            const string expectedText = @"struct TestStruct
{
    internal delegate string TestStructNestedDelegate();
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new Collection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    Visibility = StructMemberVisibilityModifier.Internal,
                                    ReturnType = new TypeReference(typeof(string))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestPrivateStructNestedDelegate()
        {
            const string expectedText = @"struct TestStruct
{
    private delegate string TestStructNestedDelegate();
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new Collection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    Visibility = StructMemberVisibilityModifier.Private,
                                    ReturnType = new TypeReference(typeof(string))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedDelegateWith1GenericParameter()
        {
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<T>();
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new Collection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
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
        public void TestStructNestedDelegateWith2GenericParameters()
        {
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<TKey, TValue>();
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new Collection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
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
        public void TestStructNestedDelegateWithClassGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<T>()
        where T : class;
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new Collection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
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
        public void TestStructNestedDelegateWithStructGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<T>()
        where T : struct;
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new Collection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
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
        public void TestStructNestedDelegateWithEmptyConstructorGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<T>()
        where T : new();
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new Collection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
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
        public void TestStructNestedDelegateWithBaseClassGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<T>()
        where T : BaseClass;
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new Collection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
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
        public void TestStructNestedDelegateWith1InterfaceGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<T>()
        where T : ITestInterface;
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new Collection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
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
        public void TestStructNestedDelegateWith2InterfaceGenericParameterConstraints()
        {
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<T>()
        where T : ITestInterface, ITestInterface2;
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new Collection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
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
        public void TestStructNestedDelegateWith1GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<TParent, TChild>()
        where TChild : TParent;
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new Collection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
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
        public void TestStructNestedDelegateWith2GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<TGrandparent, TParent, TChild>()
        where TChild : TGrandparent, TParent;
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new Collection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
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
        public void TestStructNestedDelegateWithStructAndInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<T>()
        where T : struct, ITestInterface, new();
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new Collection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
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
        public void TestStructNestedDelegateWith2GenericParameterConstraints()
        {
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<TKey, TValue>()
        where TKey : ITestInterface
        where TValue : TKey;
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new Collection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
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
        public void TestStructNestedDelegateWithParameter()
        {
            const string expectedText = @"struct TestStruct
{
    delegate void TestStructNestedDelegate(string parameter1);
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new Collection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1")
                                        {
                                            Type = new TypeReference(typeof(string))
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
        public void TestStructNestedDelegateWithOutParameter()
        {
            const string expectedText = @"struct TestStruct
{
    delegate void TestStructNestedDelegate(out string parameter1);
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new Collection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1")
                                        {
                                            Modifier = MethodParameterModifier.Out,
                                            Type = new TypeReference(typeof(string))
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
        public void TestStructNestedDelegateWithRefParameter()
        {
            const string expectedText = @"struct TestStruct
{
    delegate void TestStructNestedDelegate(ref string parameter1);
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new Collection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1")
                                        {
                                            Modifier = MethodParameterModifier.Ref,
                                            Type = new TypeReference(typeof(string))
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
        public void TestStructNestedDelegateWithParamsParameter()
        {
            const string expectedText = @"struct TestStruct
{
    delegate void TestStructNestedDelegate(params string[] parameter1);
}";             
(new CodeGenerationFile()
            {
                Structs = new Collection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new Collection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1")
                                        {
                                            Modifier = MethodParameterModifier.Params,
                                            Type = new TypeReference("string[]")
                                        }
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
