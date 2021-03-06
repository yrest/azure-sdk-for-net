// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServerManagement.Models
{
    using System.Linq;

    /// <summary>
    /// a collection of results from a powershell command
    /// </summary>
    public partial class PowerShellCommandResults
    {
        /// <summary>
        /// Initializes a new instance of the PowerShellCommandResults class.
        /// </summary>
        public PowerShellCommandResults() { }

        /// <summary>
        /// Initializes a new instance of the PowerShellCommandResults class.
        /// </summary>
        public PowerShellCommandResults(System.Collections.Generic.IList<PowerShellCommandResult> results = default(System.Collections.Generic.IList<PowerShellCommandResult>), string pssession = default(string), string command = default(string), bool? completed = default(bool?))
        {
            Results = results;
            Pssession = pssession;
            Command = command;
            Completed = completed;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "results")]
        public System.Collections.Generic.IList<PowerShellCommandResult> Results { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "pssession")]
        public string Pssession { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "command")]
        public string Command { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "completed")]
        public bool? Completed { get; set; }

    }
}
