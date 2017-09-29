using CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedClasses_NestedStructs_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedStructWith1AttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedStructWith1GenericParameterUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedStructWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedStructWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedStructWith2GenericParametersUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedStructWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedStructWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedStructWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedStructWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedStructWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalNestedStructUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalNestedStruct));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateNestedStructUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedNestedStructUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalNestedStructUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicNestedStructUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicNestedStruct));
        }
    }
}
