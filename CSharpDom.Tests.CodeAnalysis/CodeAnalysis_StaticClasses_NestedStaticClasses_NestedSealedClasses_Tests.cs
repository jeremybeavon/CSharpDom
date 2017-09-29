using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedSealedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedStaticClasses_NestedSealedClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedSealedClassWith1AttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedSealedClassWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedSealedClassWith1GenericParameterUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedSealedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedSealedClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedSealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedSealedClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedSealedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedSealedClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedSealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedSealedClassWith2GenericParametersUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedSealedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedSealedClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedSealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedSealedClassWithBaseClassUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedSealedClassWithBaseClass));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithInternalNestedSealedClassUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithInternalNestedSealedClass));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPrivateNestedSealedClassUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPrivateNestedSealedClass));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithProtectedNestedSealedClassUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithProtectedNestedSealedClass));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithProtectedInternalNestedSealedClassUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithProtectedInternalNestedSealedClass));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPublicNestedSealedClassUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPublicNestedSealedClass));
        }
    }
}
