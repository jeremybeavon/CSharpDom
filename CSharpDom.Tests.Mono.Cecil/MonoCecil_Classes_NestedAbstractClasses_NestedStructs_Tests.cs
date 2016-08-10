using CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_NestedStructs_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNestedStructWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNestedStructWith1GenericParameterUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNestedStructWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNestedStructWith2GenericParametersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNestedStructWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNestedStructWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNestedStructWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNestedStructWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalNestedStructUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalNestedStruct));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateNestedStructUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedNestedStructUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalNestedStructUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicNestedStructUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicNestedStruct));
        }
    }
}
