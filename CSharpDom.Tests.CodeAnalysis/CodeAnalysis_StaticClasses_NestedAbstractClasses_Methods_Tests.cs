using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedAbstractClasses_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMethodWith1AttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMethodWith1GenericParameterUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMethodWith1ReturnAttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMethodWith2GenericParametersUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMethodWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMethodWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithInternalMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewStaticMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewVirtualMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithOverrideMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPrivateMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedInternalMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPublicMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithSealedOverrideMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithStaticMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithVirtualMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithVirtualMethod));
        }
    }
}
