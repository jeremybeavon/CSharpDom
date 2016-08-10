using CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStructs_NestedStructs_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedStructWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedStructWith1GenericParameterUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedStructWith1ImplementedInterfaceUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedStructWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedStructWith2GenericParametersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedStructWith2ImplementedInterfacesUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedStructWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedStructWithGenericParameterClassConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedStructWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedStructWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedStructWithGenericParameterStructConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalNestedStructUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalNestedStruct));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateNestedStructUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateNestedStruct));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicNestedStructUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicNestedStruct));
        }
    }
}
