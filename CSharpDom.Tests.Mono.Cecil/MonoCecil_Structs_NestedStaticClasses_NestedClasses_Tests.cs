using CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStaticClasses_NestedClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWith1GenericParameterUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWith2GenericParametersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWithBaseClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalNestedClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithInternalNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateNestedClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithProtectedNestedClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithProtectedInternalNestedClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicNestedClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPublicNestedClass));
        }
    }
}
