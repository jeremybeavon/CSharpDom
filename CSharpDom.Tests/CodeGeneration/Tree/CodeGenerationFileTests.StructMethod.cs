using System;
using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestStructWithMethod()
        {
            const string expectedText = @"struct TestStruct
{
    void Method1()
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicMethod()
        {
            const string expectedText = @"struct TestStruct
{
    public void Method1()
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithInternalMethod()
        {
            const string expectedText = @"struct TestStruct
{
    internal void Method1()
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    Visibility = StructMemberVisibilityModifier.Internal,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithPrivateMethod()
        {
            const string expectedText = @"struct TestStruct
{
    private void Method1()
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    Visibility = StructMemberVisibilityModifier.Private,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithPublicNewMethod()
        {
            const string expectedText = @"struct TestStruct
{
    public new int GetHashCode()
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("GetHashCode")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
                                    InheritanceModifier = StructMethodInheritanceModifier.New,
                                    ReturnType = new TypeReference(typeof(int))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicNewStaticMethod()
        {
            const string expectedText = @"struct TestStruct
{
    public new static bool Equals()
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Equals")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
                                    InheritanceModifier = StructMethodInheritanceModifier.NewStatic,
                                    ReturnType = new TypeReference(typeof(bool))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithPublicOverrideMethod()
        {
            const string expectedText = @"struct TestStruct
{
    public override int GetHashCode()
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("GetHashCode")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
                                    InheritanceModifier = StructMethodInheritanceModifier.Override,
                                    ReturnType = new TypeReference(typeof(int))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithPublicStaticMethod()
        {
            const string expectedText = @"struct TestStruct
{
    public static void Method1()
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
                                    InheritanceModifier = StructMethodInheritanceModifier.Static,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
        
        /*[TestMethod]
        public void TestStructWithPublicAsyncMethod()
        {
            const string expectedText = @"struct TestStruct
{
    public async void Method1()
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
                                    IsAsync = true,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }*/

        /*[TestMethod]
        public void TestStructWithPartialMethod()
        {
            const string expectedText = @"struct TestStruct
{
    partial void Method1()
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    IsPartial = true,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }*/

        /*[TestMethod]
        public void TestStructWithAsyncPartialMethod()
        {
            const string expectedText = @"struct TestStruct
{
    async partial void Method1()
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    IsAsync = true,
                                    IsPartial = true,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }*/

        [TestMethod]
        public void TestStructWithGenericMethod()
        {
            const string expectedText = @"struct TestStruct
{
    void Method1<T>()
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
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
        public void TestStructWithGenericMethodWith2GenericParameters()
        {
            const string expectedText = @"struct TestStruct
{
    void Method1<T1, T2>()
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
                                    {
                                        new GenericParameter("T1"),
                                        new GenericParameter("T2")
                                    }
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithGenericMethodWithClassGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    void Method1<T>()
        where T : class
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
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
        public void TestStructWithGenericMethodWithStructGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    void Method1<T>()
        where T : struct
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
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
        public void TestStructWithGenericMethodWithEmptyConstructorGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    void Method1<T>()
        where T : new()
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
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
        public void TestStructWithGenericMethodWithBaseClassGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    void Method1<T>()
        where T : BaseClass
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
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
        public void TestStructWithGenericMethodWith1InterfaceGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    void Method1<T>()
        where T : ITestInterface
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
                                    {
                                        new GenericParameter("T")
                                        {
                                            InterfaceConstraints = new Collection<InterfaceReference>()
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
        public void TestStructWithGenericMethodWith2InterfaceGenericParameterConstraints()
        {
            const string expectedText = @"struct TestStruct
{
    void Method1<T>()
        where T : ITestInterface, ITestInterface2
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
                                    {
                                        new GenericParameter("T")
                                        {
                                            InterfaceConstraints = new Collection<InterfaceReference>()
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
        public void TestStructWithGenericMethodWith1GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"struct TestStruct
{
    void Method1<TParent, TChild>()
        where TChild : TParent
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
                                    {
                                        new GenericParameter("TParent"),
                                        new GenericParameter("TChild")
                                        {
                                            GenericParameterConstraints = new Collection<GenericParameterReference>()
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
        public void TestStructWithGenericMethodWith2GenericTypeGenericParameterConstraints()
        {
            const string expectedText = @"struct TestStruct
{
    void Method1<TGrandparent, TParent, TChild>()
        where TChild : TGrandparent, TParent
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
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
        public void TestStructWithGenericMethodWithStructAndInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            const string expectedText = @"struct TestStruct
{
    void Method1<T>()
        where T : struct, ITestInterface, new()
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
                                    {
                                        new GenericParameter("T")
                                        {
                                            TypeConstraint = GenericParameterTypeConstraint.Struct,
                                            InterfaceConstraints = new Collection<InterfaceReference>()
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
        public void TestStructWithGenericMethodWith2GenericParameterConstraints()
        {
            const string expectedText = @"struct TestStruct
{
    void Method1<TKey, TValue>()
        where TKey : ITestInterface
        where TValue : TKey
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new Collection<GenericParameter>()
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
        public void TestStructWithMethodWithParameter()
        {
            const string expectedText = @"struct TestStruct
{
    void Method1(string parameter1)
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
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
        public void TestStructWithMethodWithOutParameter()
        {
            const string expectedText = @"struct TestStruct
{
    void Method1(out string parameter1)
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1")
                                        {
                                            Type = new TypeReference(typeof(string)),
                                            Modifier = ParameterModifier.Out
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
        public void TestStructWithMethodWithRefParameter()
        {
            const string expectedText = @"struct TestStruct
{
    void Method1(ref string parameter1)
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1")
                                        {
                                            Type = new TypeReference(typeof(string)),
                                            Modifier = ParameterModifier.Ref
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
        public void TestStructWithMethodWithParamsParameter()
        {
            const string expectedText = @"struct TestStruct
{
    void Method1(params string[] parameter1)
    {
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
                            Methods = new Collection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1")
                                        {
                                            Type = new TypeReference("string[]"),
                                            Modifier = ParameterModifier.Params
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
