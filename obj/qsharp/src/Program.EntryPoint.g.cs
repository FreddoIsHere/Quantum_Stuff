//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
namespace Quantum_stuff
{
    using System;
    using Microsoft.Quantum.Core;
    using Microsoft.Quantum.Intrinsic;
    using Microsoft.Quantum.Simulation.Core;

    internal class __QsEntryPoint__ : Microsoft.Quantum.CsharpGeneration.EntryPointDriver.IEntryPoint<QVoid, QVoid>
    {
        public string Summary => "";
        public System.Collections.Generic.IEnumerable<System.CommandLine.Option> Options => new System.CommandLine.Option[] { };
        public string DefaultSimulator => "QuantumSimulator";
        public EntryPointInfo<QVoid, QVoid> Info => Quantum_stuff.HelloQ.Info;
        public IOperationFactory CreateDefaultCustomSimulator() => throw new InvalidOperationException();
        public QVoid CreateArgument(System.CommandLine.Parsing.ParseResult parseResult) => QVoid.Instance;
        private static async System.Threading.Tasks.Task<int> Main(string[] args) => await new Microsoft.Quantum.CsharpGeneration.EntryPointDriver.Driver<Quantum_stuff.HelloQ, QVoid, QVoid>(new __QsEntryPoint__()).Run(args);
    }
}