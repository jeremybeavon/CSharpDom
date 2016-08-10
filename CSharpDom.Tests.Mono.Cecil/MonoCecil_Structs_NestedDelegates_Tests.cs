using CSharpDom.TestTarget.Structs.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedDelegates_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedDelegateWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWith1GenericParameterUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWith2GenericParametersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithInternalNestedDelegateUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithInternalNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithParametersWithAttributesUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithParametersWithModifiersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithPrivateNestedDelegateUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithPrivateNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithPublicNestedDelegateUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithPublicNestedDelegate));
        }
    }
}
