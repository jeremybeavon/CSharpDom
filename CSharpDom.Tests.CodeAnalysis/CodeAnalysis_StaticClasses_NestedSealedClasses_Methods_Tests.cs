using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedSealedClasses_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMethodWith1AttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMethodWith1GenericParameterUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMethodWith1ReturnAttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMethodWith2GenericParametersUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMethodWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMethodWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithInternalMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithOverrideMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPrivateMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedInternalMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPublicMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithSealedOverrideMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticMethod));
        }
    }
}
