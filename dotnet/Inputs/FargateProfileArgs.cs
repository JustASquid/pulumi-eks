// *** WARNING: this file was generated by pulumi-gen-eks. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Eks.Inputs
{

    /// <summary>
    /// Defines how Kubernetes pods are executed in Fargate. See aws.eks.FargateProfileArgs for reference.
    /// </summary>
    public sealed class FargateProfileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specify a custom role to use for executing pods in Fargate. Defaults to creating a new role with the `arn:aws:iam::aws:policy/AmazonEKSFargatePodExecutionRolePolicy` policy attached.
        /// </summary>
        [Input("podExecutionRoleArn")]
        public Input<string>? PodExecutionRoleArn { get; set; }

        [Input("subnetIds")]
        private InputList<string>? _subnetIds;

        /// <summary>
        /// Specify the subnets in which to execute Fargate tasks for pods. Defaults to the private subnets associated with the cluster.
        /// </summary>
        public InputList<string> SubnetIds
        {
            get => _subnetIds ?? (_subnetIds = new InputList<string>());
            set => _subnetIds = value;
        }

        public FargateProfileArgs()
        {
        }
    }
}