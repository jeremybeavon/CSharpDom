using CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedSealedClasses_NestedDelegates_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedDelegateWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedDelegateWith1GenericParameterUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedDelegateWith2GenericParametersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedDelegateWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedDelegateWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalNestedDelegateUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedDelegateWithParametersWithAttributesUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedDelegateWithParametersWithModifiersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateNestedDelegateUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedNestedDelegateUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalNestedDelegateUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicNestedDelegateUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicNestedDelegate));
        }
    }
}
