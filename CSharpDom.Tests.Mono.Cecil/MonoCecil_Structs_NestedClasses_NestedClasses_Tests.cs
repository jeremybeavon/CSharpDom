using CSharpDom.TestTarget.Structs.NestedClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_NestedClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWith1GenericParameterUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWith2GenericParametersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWithBaseClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalNestedClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateNestedClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedNestedClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalNestedClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicNestedClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicNestedClass));
        }
    }
}
