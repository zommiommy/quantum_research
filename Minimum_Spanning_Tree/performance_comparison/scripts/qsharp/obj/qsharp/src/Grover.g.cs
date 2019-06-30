#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Grover\",\"Name\":\"HelloQ\"},\"SourceFile\":\"C:/Users/Valerio/Documents/Progetti/Grover/Grover.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"HelloQ\"},\"SourceFile\":\"C:/Users/Valerio/Documents/Progetti/Grover/Grover.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Grover\",\"Name\":\"PrepareBitString\"},\"SourceFile\":\"C:/Users/Valerio/Documents/Progetti/Grover/Grover.qs\",\"Position\":{\"Item1\":10,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bitstring\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":56}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"PrepareBitString\"},\"SourceFile\":\"C:/Users/Valerio/Documents/Progetti/Grover/Grover.qs\",\"Position\":{\"Item1\":10,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"PrepareBitString\"},\"SourceFile\":\"C:/Users/Valerio/Documents/Progetti/Grover/Grover.qs\",\"Position\":{\"Item1\":10,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":5},\"Item2\":{\"Line\":2,\"Column\":14}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Grover.PrepareBitString\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"PrepareBitString\"},\"SourceFile\":\"C:/Users/Valerio/Documents/Progetti/Grover/Grover.qs\",\"Position\":{\"Item1\":10,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":5},\"Item2\":{\"Line\":2,\"Column\":14}},\"Documentation\":[\"automatically generated QsControlled specialization for Grover.PrepareBitString\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"PrepareBitString\"},\"SourceFile\":\"C:/Users/Valerio/Documents/Progetti/Grover/Grover.qs\",\"Position\":{\"Item1\":10,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":5},\"Item2\":{\"Line\":2,\"Column\":14}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Grover.PrepareBitString\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Grover\",\"Name\":\"RegisterSetup\"},\"SourceFile\":\"C:/Users/Valerio/Documents/Progetti/Grover/Grover.qs\",\"Position\":{\"Item1\":21,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":33}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"RegisterSetup\"},\"SourceFile\":\"C:/Users/Valerio/Documents/Progetti/Grover/Grover.qs\",\"Position\":{\"Item1\":21,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Grover\",\"Name\":\"BooleanOracle\"},\"SourceFile\":\"C:/Users/Valerio/Documents/Progetti/Grover/Grover.qs\",\"Position\":{\"Item1\":33,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElement\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":55}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"BooleanOracle\"},\"SourceFile\":\"C:/Users/Valerio/Documents/Progetti/Grover/Grover.qs\",\"Position\":{\"Item1\":33,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Grover\",\"Name\":\"Grover\"},\"SourceFile\":\"C:/Users/Valerio/Documents/Progetti/Grover/Grover.qs\",\"Position\":{\"Item1\":55,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"registerComplete\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"Grover\"},\"SourceFile\":\"C:/Users/Valerio/Documents/Progetti/Grover/Grover.qs\",\"Position\":{\"Item1\":55,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Grover\",\"Name\":\"ApplyGroverSearch\"},\"SourceFile\":\"C:/Users/Valerio/Documents/Progetti/Grover/Grover.qs\",\"Position\":{\"Item1\":74,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElement\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":43}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nIterations\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":62}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nDatabaseQubits\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":70},\"Item2\":{\"Line\":1,\"Column\":85}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Result\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Grover\",\"Name\":\"ApplyGroverSearch\"},\"SourceFile\":\"C:/Users/Valerio/Documents/Progetti/Grover/Grover.qs\",\"Position\":{\"Item1\":74,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
#line hidden
namespace Grover
{
    public partial class HelloQ : Operation<QVoid, QVoid>, ICallable
    {
        public HelloQ(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "HelloQ";
        String ICallable.FullName => "Grover.HelloQ";
        protected ICallable<String, QVoid> MicrosoftQuantumIntrinsicMessage
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 8 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            MicrosoftQuantumIntrinsicMessage.Apply("Hello quantum world!");
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicMessage = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Message));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<HelloQ, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class PrepareBitString : Unitary<(IQArray<Boolean>,IQArray<Qubit>)>, ICallable
    {
        public PrepareBitString(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Boolean>,IQArray<Qubit>)>, IApplyData
        {
            public In((IQArray<Boolean>,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "PrepareBitString";
        String ICallable.FullName => "Grover.PrepareBitString";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Boolean>,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (bitstring,register) = __in__;
#line 14 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            var nQubits = register.Length;
#line 15 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            foreach (var idxQubit in new Range(0L, (nQubits - 1L)))
#line hidden
            {
#line 16 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
                if (bitstring[idxQubit])
                {
#line 17 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
                    MicrosoftQuantumIntrinsicX.Apply(register[idxQubit]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Boolean>,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (bitstring,register) = __in__;
#line hidden
            var nQubits = register.Length;
#line hidden
            foreach (var idxQubit in RangeReverse.Apply(new Range(0L, (nQubits - 1L))))
#line hidden
            {
#line hidden
                if (bitstring[idxQubit])
                {
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(register[idxQubit]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Boolean>,IQArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(bitstring,register)) = __in__;
#line hidden
            var nQubits = register.Length;
#line hidden
            foreach (var idxQubit in new Range(0L, (nQubits - 1L)))
#line hidden
            {
#line hidden
                if (bitstring[idxQubit])
                {
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, register[idxQubit]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Boolean>,IQArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(bitstring,register)) = __in__;
#line hidden
            var nQubits = register.Length;
#line hidden
            foreach (var idxQubit in RangeReverse.Apply(new Range(0L, (nQubits - 1L))))
#line hidden
            {
#line hidden
                if (bitstring[idxQubit])
                {
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Controlled.Apply((__controlQubits__, register[idxQubit]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Boolean>,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Boolean> bitstring, IQArray<Qubit> register)
        {
            return __m__.Run<PrepareBitString, (IQArray<Boolean>,IQArray<Qubit>), QVoid>((bitstring, register));
        }
    }

    public partial class RegisterSetup : Operation<IQArray<Qubit>, QVoid>, ICallable
    {
        public RegisterSetup(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "RegisterSetup";
        String ICallable.FullName => "Grover.RegisterSetup";
        protected IUnitary<(IQArray<Boolean>,IQArray<Qubit>)> PrepareBitString
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var register = __in__;
#line 23 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            var registerDB = (IQArray<Boolean>)QArray<Boolean>.Create((register.Length - 1L));
#line 24 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            var ancilla = (IQArray<Boolean>)new QArray<Boolean>(true);
#line 25 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            var registerTemplate = (IQArray<Boolean>)QArray<Boolean>.Add(registerDB, ancilla);
#line 27 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            PrepareBitString.Apply((registerTemplate, register));
#line 29 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            foreach (var q in register)
#line hidden
            {
#line 30 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
                MicrosoftQuantumIntrinsicH.Apply(q);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.PrepareBitString = this.Factory.Get<IUnitary<(IQArray<Boolean>,IQArray<Qubit>)>>(typeof(PrepareBitString));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> register)
        {
            return __m__.Run<RegisterSetup, IQArray<Qubit>, QVoid>(register);
        }
    }

    public partial class BooleanOracle : Operation<(Int64,IQArray<Qubit>), QVoid>, ICallable
    {
        public BooleanOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,IQArray<Qubit>)>, IApplyData
        {
            public In((Int64,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "BooleanOracle";
        String ICallable.FullName => "Grover.BooleanOracle";
        protected ICallable<(Int64,Int64), IQArray<Boolean>> MicrosoftQuantumConvertIntAsBoolArray
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(Int64,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (markedElement,register) = __in__;
#line 35 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            var databaseSize = (register.Length - 1L);
#line 36 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            var boolMarked = (IQArray<Boolean>)MicrosoftQuantumConvertIntAsBoolArray.Apply((markedElement, databaseSize));
#line 38 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            foreach (var i in new Range(0L, (databaseSize - 1L)))
#line hidden
            {
#line 39 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
                if ((boolMarked[i] == false))
                {
#line 40 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
                    MicrosoftQuantumIntrinsicX.Apply(register[((databaseSize - i) - 1L)]);
                }
            }

#line 44 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            var controls = (IQArray<Qubit>)register?.Slice(new Range(0L, (register.Length - 2L)));
#line 45 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            var target = register[(register.Length - 1L)];
#line 47 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            MicrosoftQuantumIntrinsicX.Controlled.Apply((controls, target));
#line 49 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            foreach (var i in new Range(0L, (databaseSize - 1L)))
#line hidden
            {
#line 50 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
                if ((boolMarked[i] == false))
                {
#line 51 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
                    MicrosoftQuantumIntrinsicX.Apply(register[((databaseSize - i) - 1L)]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsBoolArray = this.Factory.Get<ICallable<(Int64,Int64), IQArray<Boolean>>>(typeof(Microsoft.Quantum.Convert.IntAsBoolArray));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((Int64,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 markedElement, IQArray<Qubit> register)
        {
            return __m__.Run<BooleanOracle, (Int64,IQArray<Qubit>), QVoid>((markedElement, register));
        }
    }

    public partial class Grover : Operation<IQArray<Qubit>, QVoid>, ICallable
    {
        public Grover(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Grover";
        String ICallable.FullName => "Grover.Grover";
        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicZ
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var registerComplete = __in__;
#line 57 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            var register = (IQArray<Qubit>)registerComplete?.Slice(new Range(0L, (registerComplete.Length - 2L)));
#line 59 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            foreach (var q in register)
#line hidden
            {
#line 60 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
                MicrosoftQuantumIntrinsicH.Apply(q);
#line 61 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
                MicrosoftQuantumIntrinsicX.Apply(q);
            }

#line 64 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            var controls = (IQArray<Qubit>)register?.Slice(new Range(0L, (register.Length - 2L)));
#line 65 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            var target = register[(register.Length - 1L)];
#line 67 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            MicrosoftQuantumIntrinsicZ.Controlled.Apply((controls, target));
#line 69 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            foreach (var q in register)
#line hidden
            {
#line 70 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
                MicrosoftQuantumIntrinsicX.Apply(q);
#line 71 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
                MicrosoftQuantumIntrinsicH.Apply(q);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> registerComplete)
        {
            return __m__.Run<Grover, IQArray<Qubit>, QVoid>(registerComplete);
        }
    }

    public partial class ApplyGroverSearch : Operation<(Int64,Int64,Int64), Result>, ICallable
    {
        public ApplyGroverSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ApplyGroverSearch";
        String ICallable.FullName => "Grover.ApplyGroverSearch";
        protected ICallable<(Int64,IQArray<Qubit>), QVoid> BooleanOracle
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> Grover
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> RegisterSetup
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> MicrosoftQuantumIntrinsicMessage
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Int64), Result> Body => (__in__) =>
        {
            var (markedElement,nIterations,nDatabaseQubits) = __in__;
#line 76 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            var resultSuccess = Result.Zero;
#line hidden
            {
#line 78 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
                var qubits = Allocate.Apply((nDatabaseQubits + 1L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 79 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
                    RegisterSetup.Apply(qubits);
#line 81 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
                    foreach (var i in new Range(1L, nIterations))
#line hidden
                    {
#line 82 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
                        BooleanOracle.Apply((markedElement, qubits));
#line 83 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
                        Grover.Apply(qubits);
                    }

#line 86 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
                    foreach (var i in new Range(0L, (nDatabaseQubits - 1L)))
#line hidden
                    {
#line 87 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(qubits[i]) == Result.One))
                        {
#line 88 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
                            MicrosoftQuantumIntrinsicMessage.Apply("1");
                        }
                        else
                        {
#line 91 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
                            MicrosoftQuantumIntrinsicMessage.Apply("0");
                        }
                    }

#line 95 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
                    MicrosoftQuantumIntrinsicResetAll.Apply(qubits);
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(qubits);
                }
            }

#line 98 "C:\\Users\\Valerio\\Documents\\Progetti\\Grover\\Grover.qs"
            return resultSuccess;
        }

        ;
        public override void Init()
        {
            this.BooleanOracle = this.Factory.Get<ICallable<(Int64,IQArray<Qubit>), QVoid>>(typeof(BooleanOracle));
            this.Grover = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Grover));
            this.RegisterSetup = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(RegisterSetup));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumIntrinsicMessage = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
        }

        public override IApplyData __dataIn((Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, Int64 markedElement, Int64 nIterations, Int64 nDatabaseQubits)
        {
            return __m__.Run<ApplyGroverSearch, (Int64,Int64,Int64), Result>((markedElement, nIterations, nDatabaseQubits));
        }
    }
}