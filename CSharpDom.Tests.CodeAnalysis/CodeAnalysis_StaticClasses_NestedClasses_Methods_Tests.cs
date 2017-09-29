using CSharpDom.TestTarget.StaticClasses.NestedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedClasses_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWith1AttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWith1GenericParameterUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWith1ReturnAttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWith2GenericParametersUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVirtualMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverrideMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithSealedOverrideMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualMethod));
        }
    }
}
