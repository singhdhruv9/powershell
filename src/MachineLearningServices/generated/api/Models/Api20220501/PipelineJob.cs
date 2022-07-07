// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Pipeline Job definition: defines generic to MFE attributes.</summary>
    public partial class PipelineJob :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPipelineJob,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPipelineJobInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBaseProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBaseProperties __jobBaseProperties = new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.JobBaseProperties();

        /// <summary>ARM resource ID of the compute resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string ComputeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)__jobBaseProperties).ComputeId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)__jobBaseProperties).ComputeId = value ?? null; }

        /// <summary>The asset description text.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)__jobBaseProperties).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)__jobBaseProperties).Description = value ?? null; }

        /// <summary>Display name of job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)__jobBaseProperties).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)__jobBaseProperties).DisplayName = value ?? null; }

        /// <summary>
        /// The name of the experiment the job belongs to. If not set, the job is placed in the "Default" experiment.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string ExperimentName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)__jobBaseProperties).ExperimentName; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)__jobBaseProperties).ExperimentName = value ?? null; }

        /// <summary>
        /// Identity configuration. If set, this should be one of AmlToken, ManagedIdentity, UserIdentity or null.
        /// Defaults to AmlToken if null.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IIdentityConfiguration Identity { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)__jobBaseProperties).Identity; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)__jobBaseProperties).Identity = value ?? null /* model class */; }

        /// <summary>[Required] Specifies the type of identity framework.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.IdentityConfigurationType? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)__jobBaseProperties).IdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)__jobBaseProperties).IdentityType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.IdentityConfigurationType)""); }

        /// <summary>Backing field for <see cref="Input" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPipelineJobInputs _input;

        /// <summary>Inputs for the pipeline job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPipelineJobInputs Input { get => (this._input = this._input ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.PipelineJobInputs()); set => this._input = value; }

        /// <summary>Is the asset archived?</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public bool? IsArchived { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)__jobBaseProperties).IsArchived; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)__jobBaseProperties).IsArchived = value ?? default(bool); }

        /// <summary>Backing field for <see cref="Job" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPipelineJobJobs _job;

        /// <summary>Jobs construct the Pipeline Job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPipelineJobJobs Job { get => (this._job = this._job ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.PipelineJobJobs()); set => this._job = value; }

        /// <summary>[Required] Specifies the type of job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobType JobType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)__jobBaseProperties).JobType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)__jobBaseProperties).JobType = value ; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobStatus? Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)__jobBaseProperties).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)__jobBaseProperties).Status = value; }

        /// <summary>Backing field for <see cref="Output" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPipelineJobOutputs _output;

        /// <summary>Outputs for the pipeline job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPipelineJobOutputs Output { get => (this._output = this._output ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.PipelineJobOutputs()); set => this._output = value; }

        /// <summary>The asset property dictionary.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseProperties Property { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)__jobBaseProperties).Property; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)__jobBaseProperties).Property = value ?? null /* model class */; }

        /// <summary>
        /// List of JobEndpoints.
        /// For local jobs, a job endpoint will have an endpoint value of FileStreamObject.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBaseServices Service { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)__jobBaseProperties).Service; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)__jobBaseProperties).Service = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Setting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IAny _setting;

        /// <summary>Pipeline settings, for things like ContinueRunOnStepFailure etc.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IAny Setting { get => (this._setting = this._setting ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Any()); set => this._setting = value; }

        /// <summary>Status of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobStatus? Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)__jobBaseProperties).Status; }

        /// <summary>Tag dictionary. Tags can be added, removed, and updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)__jobBaseProperties).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)__jobBaseProperties).Tag = value ?? null /* model class */; }

        /// <summary>Creates an new <see cref="PipelineJob" /> instance.</summary>
        public PipelineJob()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__jobBaseProperties), __jobBaseProperties);
            await eventListener.AssertObjectIsValid(nameof(__jobBaseProperties), __jobBaseProperties);
        }
    }
    /// Pipeline Job definition: defines generic to MFE attributes.
    public partial interface IPipelineJob :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBaseProperties
    {
        /// <summary>Inputs for the pipeline job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Inputs for the pipeline job.",
        SerializedName = @"inputs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPipelineJobInputs) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPipelineJobInputs Input { get; set; }
        /// <summary>Jobs construct the Pipeline Job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Jobs construct the Pipeline Job.",
        SerializedName = @"jobs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPipelineJobJobs) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPipelineJobJobs Job { get; set; }
        /// <summary>Outputs for the pipeline job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Outputs for the pipeline job",
        SerializedName = @"outputs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPipelineJobOutputs) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPipelineJobOutputs Output { get; set; }
        /// <summary>Pipeline settings, for things like ContinueRunOnStepFailure etc.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Pipeline settings, for things like ContinueRunOnStepFailure etc.",
        SerializedName = @"settings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IAny Setting { get; set; }

    }
    /// Pipeline Job definition: defines generic to MFE attributes.
    internal partial interface IPipelineJobInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal
    {
        /// <summary>Inputs for the pipeline job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPipelineJobInputs Input { get; set; }
        /// <summary>Jobs construct the Pipeline Job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPipelineJobJobs Job { get; set; }
        /// <summary>Outputs for the pipeline job</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPipelineJobOutputs Output { get; set; }
        /// <summary>Pipeline settings, for things like ContinueRunOnStepFailure etc.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IAny Setting { get; set; }

    }
}