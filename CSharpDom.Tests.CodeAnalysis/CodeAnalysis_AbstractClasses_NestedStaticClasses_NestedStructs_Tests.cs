using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedStaticClasses_NestedStructs_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWith1AttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWith1GenericParameterUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWith2GenericParametersUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithInternalNestedStructUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithInternalNestedStruct));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPrivateNestedStructUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithProtectedNestedStructUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithProtectedInternalNestedStructUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPublicNestedStructUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPublicNestedStruct));
        }
    }
}
