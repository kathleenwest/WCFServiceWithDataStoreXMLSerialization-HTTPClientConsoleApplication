﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HttpClient.MathServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MathServiceRef.IMathService")]
    public interface IMathService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Add", ReplyAction="http://tempuri.org/IMathService/AddResponse")]
        double Add(double value1, double value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Add", ReplyAction="http://tempuri.org/IMathService/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(double value1, double value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Subtract", ReplyAction="http://tempuri.org/IMathService/SubtractResponse")]
        double Subtract(double value1, double value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Subtract", ReplyAction="http://tempuri.org/IMathService/SubtractResponse")]
        System.Threading.Tasks.Task<double> SubtractAsync(double value1, double value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Multiply", ReplyAction="http://tempuri.org/IMathService/MultiplyResponse")]
        double Multiply(double value1, double value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Multiply", ReplyAction="http://tempuri.org/IMathService/MultiplyResponse")]
        System.Threading.Tasks.Task<double> MultiplyAsync(double value1, double value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Divide", ReplyAction="http://tempuri.org/IMathService/DivideResponse")]
        double Divide(double value1, double value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Divide", ReplyAction="http://tempuri.org/IMathService/DivideResponse")]
        System.Threading.Tasks.Task<double> DivideAsync(double value1, double value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/CircleArea", ReplyAction="http://tempuri.org/IMathService/CircleAreaResponse")]
        double CircleArea(double radius);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/CircleArea", ReplyAction="http://tempuri.org/IMathService/CircleAreaResponse")]
        System.Threading.Tasks.Task<double> CircleAreaAsync(double radius);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMathServiceChannel : HttpClient.MathServiceRef.IMathService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MathServiceClient : System.ServiceModel.ClientBase<HttpClient.MathServiceRef.IMathService>, HttpClient.MathServiceRef.IMathService {
        
        public MathServiceClient() {
        }
        
        public MathServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MathServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double value1, double value2) {
            return base.Channel.Add(value1, value2);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(double value1, double value2) {
            return base.Channel.AddAsync(value1, value2);
        }
        
        public double Subtract(double value1, double value2) {
            return base.Channel.Subtract(value1, value2);
        }
        
        public System.Threading.Tasks.Task<double> SubtractAsync(double value1, double value2) {
            return base.Channel.SubtractAsync(value1, value2);
        }
        
        public double Multiply(double value1, double value2) {
            return base.Channel.Multiply(value1, value2);
        }
        
        public System.Threading.Tasks.Task<double> MultiplyAsync(double value1, double value2) {
            return base.Channel.MultiplyAsync(value1, value2);
        }
        
        public double Divide(double value1, double value2) {
            return base.Channel.Divide(value1, value2);
        }
        
        public System.Threading.Tasks.Task<double> DivideAsync(double value1, double value2) {
            return base.Channel.DivideAsync(value1, value2);
        }
        
        public double CircleArea(double radius) {
            return base.Channel.CircleArea(radius);
        }
        
        public System.Threading.Tasks.Task<double> CircleAreaAsync(double radius) {
            return base.Channel.CircleAreaAsync(radius);
        }
    }
}
