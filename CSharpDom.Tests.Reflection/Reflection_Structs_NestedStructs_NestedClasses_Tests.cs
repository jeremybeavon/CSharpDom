using CSharpDom.TestTarget.Structs.NestedStructs.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_NestedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithNestedClassWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedClassWith1GenericParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedClassWith1ImplementedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedClassWith2GenericParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedClassWith2ImplementedInterfacesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedClassWithBaseClassUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalNestedClassUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateNestedClassUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicNestedClassUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicNestedClass));
        }
    }
}
