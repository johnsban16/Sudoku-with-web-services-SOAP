﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sudoku.SudokuService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:ECCI_Sudoku", ConfigurationName="SudokuService.ECCI_SudokuPort")]
    public interface ECCI_SudokuPort {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Sudoku#Sudoku#checkRow", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        bool checkRow(int rowNum);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_Sudoku#Sudoku#checkColumn", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        bool checkColumn(int columnNum);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ECCI_SudokuPortChannel : Sudoku.SudokuService.ECCI_SudokuPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ECCI_SudokuPortClient : System.ServiceModel.ClientBase<Sudoku.SudokuService.ECCI_SudokuPort>, Sudoku.SudokuService.ECCI_SudokuPort {
        
        public ECCI_SudokuPortClient() {
        }
        
        public ECCI_SudokuPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ECCI_SudokuPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ECCI_SudokuPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ECCI_SudokuPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool checkRow(int rowNum) {
            return base.Channel.checkRow(rowNum);
        }
        
        public bool checkColumn(int columnNum) {
            return base.Channel.checkColumn(columnNum);
        }
    }
}
