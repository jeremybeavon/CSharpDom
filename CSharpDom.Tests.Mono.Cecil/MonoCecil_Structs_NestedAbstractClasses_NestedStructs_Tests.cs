using CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_NestedStructs_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedStructWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedStructWith1GenericParameterUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedStructWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedStructWith2GenericParametersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedStructWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedStructWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedStructWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedStructWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedStructWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalNestedStructUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalNestedStruct));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateNestedStructUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedNestedStructUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalNestedStructUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicNestedStructUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicNestedStruct));
        }
    }
}
