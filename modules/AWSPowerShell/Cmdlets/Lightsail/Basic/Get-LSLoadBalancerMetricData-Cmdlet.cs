/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.Lightsail;
using Amazon.Lightsail.Model;

namespace Amazon.PowerShell.Cmdlets.LS
{
    /// <summary>
    /// Returns information about health metrics for your Lightsail load balancer.
    /// </summary>
    [Cmdlet("Get", "LSLoadBalancerMetricData")]
    [OutputType("Amazon.Lightsail.Model.GetLoadBalancerMetricDataResponse")]
    [AWSCmdlet("Calls the Amazon Lightsail GetLoadBalancerMetricData API operation.", Operation = new[] {"GetLoadBalancerMetricData"}, SelectReturnType = typeof(Amazon.Lightsail.Model.GetLoadBalancerMetricDataResponse))]
    [AWSCmdletOutput("Amazon.Lightsail.Model.GetLoadBalancerMetricDataResponse",
        "This cmdlet returns an Amazon.Lightsail.Model.GetLoadBalancerMetricDataResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetLSLoadBalancerMetricDataCmdlet : AmazonLightsailClientCmdlet, IExecutor
    {
        
        #region Parameter EndTime
        /// <summary>
        /// <para>
        /// <para>The end time of the period.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.DateTime? EndTime { get; set; }
        #endregion
        
        #region Parameter LoadBalancerName
        /// <summary>
        /// <para>
        /// <para>The name of the load balancer.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String LoadBalancerName { get; set; }
        #endregion
        
        #region Parameter MetricName
        /// <summary>
        /// <para>
        /// <para>The metric about which you want to return information. Valid values are listed below,
        /// along with the most useful <code>statistics</code> to include in your request.</para><ul><li><para><b><code>ClientTLSNegotiationErrorCount</code></b> - The number of TLS connections
        /// initiated by the client that did not establish a session with the load balancer. Possible
        /// causes include a mismatch of ciphers or protocols.</para><para><code>Statistics</code>: The most useful statistic is <code>Sum</code>.</para></li><li><para><b><code>HealthyHostCount</code></b> - The number of target instances that are
        /// considered healthy.</para><para><code>Statistics</code>: The most useful statistic are <code>Average</code>, <code>Minimum</code>,
        /// and <code>Maximum</code>.</para></li><li><para><b><code>UnhealthyHostCount</code></b> - The number of target instances that are
        /// considered unhealthy.</para><para><code>Statistics</code>: The most useful statistic are <code>Average</code>, <code>Minimum</code>,
        /// and <code>Maximum</code>.</para></li><li><para><b><code>HTTPCode_LB_4XX_Count</code></b> - The number of HTTP 4XX client error
        /// codes that originate from the load balancer. Client errors are generated when requests
        /// are malformed or incomplete. These requests have not been received by the target instance.
        /// This count does not include any response codes generated by the target instances.</para><para><code>Statistics</code>: The most useful statistic is <code>Sum</code>. Note that
        /// <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all return <code>1</code>.</para></li><li><para><b><code>HTTPCode_LB_5XX_Count</code></b> - The number of HTTP 5XX server error
        /// codes that originate from the load balancer. This count does not include any response
        /// codes generated by the target instances.</para><para><code>Statistics</code>: The most useful statistic is <code>Sum</code>. Note that
        /// <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all return <code>1</code>.
        /// Note that <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all
        /// return <code>1</code>.</para></li><li><para><b><code>HTTPCode_Instance_2XX_Count</code></b> - The number of HTTP response codes
        /// generated by the target instances. This does not include any response codes generated
        /// by the load balancer.</para><para><code>Statistics</code>: The most useful statistic is <code>Sum</code>. Note that
        /// <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all return <code>1</code>.</para></li><li><para><b><code>HTTPCode_Instance_3XX_Count</code></b> - The number of HTTP response codes
        /// generated by the target instances. This does not include any response codes generated
        /// by the load balancer. </para><para><code>Statistics</code>: The most useful statistic is <code>Sum</code>. Note that
        /// <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all return <code>1</code>.</para></li><li><para><b><code>HTTPCode_Instance_4XX_Count</code></b> - The number of HTTP response codes
        /// generated by the target instances. This does not include any response codes generated
        /// by the load balancer.</para><para><code>Statistics</code>: The most useful statistic is <code>Sum</code>. Note that
        /// <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all return <code>1</code>.</para></li><li><para><b><code>HTTPCode_Instance_5XX_Count</code></b> - The number of HTTP response codes
        /// generated by the target instances. This does not include any response codes generated
        /// by the load balancer.</para><para><code>Statistics</code>: The most useful statistic is <code>Sum</code>. Note that
        /// <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all return <code>1</code>.</para></li><li><para><b><code>InstanceResponseTime</code></b> - The time elapsed, in seconds, after
        /// the request leaves the load balancer until a response from the target instance is
        /// received.</para><para><code>Statistics</code>: The most useful statistic is <code>Average</code>.</para></li><li><para><b><code>RejectedConnectionCount</code></b> - The number of connections that were
        /// rejected because the load balancer had reached its maximum number of connections.</para><para><code>Statistics</code>: The most useful statistic is <code>Sum</code>.</para></li><li><para><b><code>RequestCount</code></b> - The number of requests processed over IPv4.
        /// This count includes only the requests with a response generated by a target instance
        /// of the load balancer.</para><para><code>Statistics</code>: The most useful statistic is <code>Sum</code>. Note that
        /// <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all return <code>1</code>.</para></li></ul>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.Lightsail.LoadBalancerMetricName")]
        public Amazon.Lightsail.LoadBalancerMetricName MetricName { get; set; }
        #endregion
        
        #region Parameter Period
        /// <summary>
        /// <para>
        /// <para>The granularity, in seconds, of the returned data points.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.Int32? Period { get; set; }
        #endregion
        
        #region Parameter StartTime
        /// <summary>
        /// <para>
        /// <para>The start time of the period.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.DateTime? StartTime { get; set; }
        #endregion
        
        #region Parameter Statistic
        /// <summary>
        /// <para>
        /// <para>An array of statistics that you want to request metrics for. Valid values are listed
        /// below.</para><ul><li><para><b><code>SampleCount</code></b> - The count (number) of data points used for the
        /// statistical calculation.</para></li><li><para><b><code>Average</code></b> - The value of Sum / SampleCount during the specified
        /// period. By comparing this statistic with the Minimum and Maximum, you can determine
        /// the full scope of a metric and how close the average use is to the Minimum and Maximum.
        /// This comparison helps you to know when to increase or decrease your resources as needed.</para></li><li><para><b><code>Sum</code></b> - All values submitted for the matching metric added together.
        /// This statistic can be useful for determining the total volume of a metric.</para></li><li><para><b><code>Minimum</code></b> - The lowest value observed during the specified period.
        /// You can use this value to determine low volumes of activity for your application.</para></li><li><para><b><code>Maximum</code></b> - The highest value observed during the specified period.
        /// You can use this value to determine high volumes of activity for your application.</para></li></ul>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [Alias("Statistics")]
        public System.String[] Statistic { get; set; }
        #endregion
        
        #region Parameter Unit
        /// <summary>
        /// <para>
        /// <para>The unit for the time period request. Valid values are listed below.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.Lightsail.MetricUnit")]
        public Amazon.Lightsail.MetricUnit Unit { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Lightsail.Model.GetLoadBalancerMetricDataResponse).
        /// Specifying the name of a property of type Amazon.Lightsail.Model.GetLoadBalancerMetricDataResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the LoadBalancerName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^LoadBalancerName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^LoadBalancerName' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Lightsail.Model.GetLoadBalancerMetricDataResponse, GetLSLoadBalancerMetricDataCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.LoadBalancerName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.EndTime = this.EndTime;
            #if MODULAR
            if (this.EndTime == null && ParameterWasBound(nameof(this.EndTime)))
            {
                WriteWarning("You are passing $null as a value for parameter EndTime which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.LoadBalancerName = this.LoadBalancerName;
            #if MODULAR
            if (this.LoadBalancerName == null && ParameterWasBound(nameof(this.LoadBalancerName)))
            {
                WriteWarning("You are passing $null as a value for parameter LoadBalancerName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.MetricName = this.MetricName;
            #if MODULAR
            if (this.MetricName == null && ParameterWasBound(nameof(this.MetricName)))
            {
                WriteWarning("You are passing $null as a value for parameter MetricName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Period = this.Period;
            #if MODULAR
            if (this.Period == null && ParameterWasBound(nameof(this.Period)))
            {
                WriteWarning("You are passing $null as a value for parameter Period which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.StartTime = this.StartTime;
            #if MODULAR
            if (this.StartTime == null && ParameterWasBound(nameof(this.StartTime)))
            {
                WriteWarning("You are passing $null as a value for parameter StartTime which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.Statistic != null)
            {
                context.Statistic = new List<System.String>(this.Statistic);
            }
            #if MODULAR
            if (this.Statistic == null && ParameterWasBound(nameof(this.Statistic)))
            {
                WriteWarning("You are passing $null as a value for parameter Statistic which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Unit = this.Unit;
            #if MODULAR
            if (this.Unit == null && ParameterWasBound(nameof(this.Unit)))
            {
                WriteWarning("You are passing $null as a value for parameter Unit which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.Lightsail.Model.GetLoadBalancerMetricDataRequest();
            
            if (cmdletContext.EndTime != null)
            {
                request.EndTime = cmdletContext.EndTime.Value;
            }
            if (cmdletContext.LoadBalancerName != null)
            {
                request.LoadBalancerName = cmdletContext.LoadBalancerName;
            }
            if (cmdletContext.MetricName != null)
            {
                request.MetricName = cmdletContext.MetricName;
            }
            if (cmdletContext.Period != null)
            {
                request.Period = cmdletContext.Period.Value;
            }
            if (cmdletContext.StartTime != null)
            {
                request.StartTime = cmdletContext.StartTime.Value;
            }
            if (cmdletContext.Statistic != null)
            {
                request.Statistics = cmdletContext.Statistic;
            }
            if (cmdletContext.Unit != null)
            {
                request.Unit = cmdletContext.Unit;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.Lightsail.Model.GetLoadBalancerMetricDataResponse CallAWSServiceOperation(IAmazonLightsail client, Amazon.Lightsail.Model.GetLoadBalancerMetricDataRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Lightsail", "GetLoadBalancerMetricData");
            try
            {
                #if DESKTOP
                return client.GetLoadBalancerMetricData(request);
                #elif CORECLR
                return client.GetLoadBalancerMetricDataAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public System.DateTime? EndTime { get; set; }
            public System.String LoadBalancerName { get; set; }
            public Amazon.Lightsail.LoadBalancerMetricName MetricName { get; set; }
            public System.Int32? Period { get; set; }
            public System.DateTime? StartTime { get; set; }
            public List<System.String> Statistic { get; set; }
            public Amazon.Lightsail.MetricUnit Unit { get; set; }
            public System.Func<Amazon.Lightsail.Model.GetLoadBalancerMetricDataResponse, GetLSLoadBalancerMetricDataCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}