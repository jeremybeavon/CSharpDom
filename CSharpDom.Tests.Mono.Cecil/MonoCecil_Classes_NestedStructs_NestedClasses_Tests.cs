using CSharpDom.TestTarget.Classes.NestedStructs.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_NestedClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithNestedClassWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedClassWith1GenericParameterUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedClassWith2GenericParametersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedClassWithBaseClassUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalNestedClassUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalNestedClass));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateNestedClassUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicNestedClassUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicNestedClass));
        }
    }
}
