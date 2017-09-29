using CSharpDom.TestTarget.StaticClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithMethodWith1AttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith1GenericParameterUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith1ReturnAttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith2GenericParametersUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithInternalMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStaticClassWithPublicMethodUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithPublicMethod));
        }
    }
}
