using CSharpDom.TestTarget.Classes.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithMethodWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithMethodWith1GenericParameterUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithMethodWith1ReturnAttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestClassWithMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithMethodWith2GenericParametersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithInternalMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNewMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewMethod));
        }

        [TestMethod]
        public void TestClassWithNewStaticMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestClassWithNewVirtualMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestClassWithOverrideMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithPrivateMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestClassWithProtectedMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestClassWithPublicMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPublicMethod));
        }

        [TestMethod]
        public void TestClassWithSealedOverrideMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithStaticMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithStaticMethod));
        }

        [TestMethod]
        public void TestClassWithVirtualMethodUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithVirtualMethod));
        }
    }
}
