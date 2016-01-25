using System;
using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestClassWithMethod()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicMethod()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithInternalMethod()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Internal,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    internal void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithProtectedInternalMethod()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.ProtectedInternal,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    protected internal void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithProtectedMethod()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Protected,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    protected void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPrivateMethod()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Private,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    private void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicAbstractMethod()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.Abstract,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public abstract void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicNewMethod()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.New,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public new void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicNewStaticMethod()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.NewStatic,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public new static void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicNewVirtualMethod()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.NewVirtual,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public new virtual void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicOverrideMethod()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.Override,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public override void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicSealedOverrideMethod()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.SealedOverride,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public sealed override void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicStaticMethod()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.Static,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public static void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicVirtualMethod()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.Virtual,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public virtual void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicVirtualAsyncMethod()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.Virtual,
                                    IsAsync = true,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public virtual async void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPartialMethod()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    IsPartial = true,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    partial void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithAsyncPartialMethod()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    IsAsync = true,
                                    IsPartial = true,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    async partial void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithGenericMethod()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
                                    {
                                        new GenericParameter("T")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    void Method1<T>()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithGenericMethodWith2GenericParameters()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
                                    {
                                        new GenericParameter("T1"),
                                        new GenericParameter("T2")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    void Method1<T1, T2>()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithGenericMethodWithClassGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
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
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    void Method1<T>()
        where T : class
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithGenericMethodWithStructGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
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
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    void Method1<T>()
        where T : struct
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithGenericMethodWithEmptyConstructorGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
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
            const string expectedText = @"class TestClass
{
    void Method1<T>()
        where T : new()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithGenericMethodWithBaseClassGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
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
            const string expectedText = @"class TestClass
{
    void Method1<T>()
        where T : BaseClass
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithGenericMethodWith1InterfaceGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
                                    {
                                        new GenericParameter("T")
                                        {
                                            InterfaceConstraints = new CodeGenerationCollection<InterfaceReference>()
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
            const string expectedText = @"class TestClass
{
    void Method1<T>()
        where T : ITestInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithGenericMethodWith2InterfaceGenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
                                    {
                                        new GenericParameter("T")
                                        {
                                            InterfaceConstraints = new CodeGenerationCollection<InterfaceReference>()
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
            const string expectedText = @"class TestClass
{
    void Method1<T>()
        where T : ITestInterface, ITestInterface2
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithGenericMethodWith1GenericTypeGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
                                    {
                                        new GenericParameter("TParent"),
                                        new GenericParameter("TChild")
                                        {
                                            GenericParameterConstraints = new CodeGenerationCollection<GenericParameterReference>()
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
            const string expectedText = @"class TestClass
{
    void Method1<TParent, TChild>()
        where TChild : TParent
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithGenericMethodWith2GenericTypeGenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
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
            const string expectedText = @"class TestClass
{
    void Method1<TGrandparent, TParent, TChild>()
        where TChild : TGrandparent, TParent
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithGenericMethodWithClassAndInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
                                    {
                                        new GenericParameter("T")
                                        {
                                            TypeConstraint = GenericParameterTypeConstraint.Class,
                                            InterfaceConstraints = new CodeGenerationCollection<InterfaceReference>()
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
            const string expectedText = @"class TestClass
{
    void Method1<T>()
        where T : class, ITestInterface, new()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithGenericMethodWith2GenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
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
            const string expectedText = @"class TestClass
{
    void Method1<TKey, TValue>()
        where TKey : ITestInterface
        where TValue : TKey
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithMethodWithParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new CodeGenerationCollection<ClassMethodParameter>()
                                    {
                                        new ClassMethodParameter("parameter1")
                                        {
                                            Type = new TypeReference(typeof(string))
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    void Method1(string parameter1)
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithMethodWithExtensionClassMethodParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        InheritanceModifier = TypeInheritanceModifier.Static,
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    InheritanceModifier = ClassMemberInheritanceModifier.Static,
                                    Parameters = new CodeGenerationCollection<ClassMethodParameter>()
                                    {
                                        new ClassMethodParameter("parameter1")
                                        {
                                            Type = new TypeReference(typeof(string)),
                                            Modifier = ClassMethodParameterModifier.This
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"static class TestClass
{
    static void Method1(this string parameter1)
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithMethodWithOutParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new CodeGenerationCollection<ClassMethodParameter>()
                                    {
                                        new ClassMethodParameter("parameter1")
                                        {
                                            Type = new TypeReference(typeof(string)),
                                            Modifier = ClassMethodParameterModifier.Out
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    void Method1(out string parameter1)
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithMethodWithRefParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new CodeGenerationCollection<ClassMethodParameter>()
                                    {
                                        new ClassMethodParameter("parameter1")
                                        {
                                            Type = new TypeReference(typeof(string)),
                                            Modifier = ClassMethodParameterModifier.Ref
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    void Method1(ref string parameter1)
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithMethodWithParamsParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Methods = new CodeGenerationCollection<ClassMethod>()
                            {
                                new ClassMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new CodeGenerationCollection<ClassMethodParameter>()
                                    {
                                        new ClassMethodParameter("parameter1")
                                        {
                                            Type = new TypeReference("string[]"),
                                            Modifier = ClassMethodParameterModifier.Params
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    void Method1(params string[] parameter1)
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
