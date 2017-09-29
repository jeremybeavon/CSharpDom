using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedSealedClasses_NestedStructs_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNestedStructWith1AttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNestedStructWith1GenericParameterUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNestedStructWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNestedStructWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNestedStructWith2GenericParametersUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNestedStructWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNestedStructWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNestedStructWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNestedStructWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNestedStructWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithInternalNestedStructUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalNestedStruct));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPrivateNestedStructUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedNestedStructUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedInternalNestedStructUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPublicNestedStructUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicNestedStruct));
        }
    }
}
