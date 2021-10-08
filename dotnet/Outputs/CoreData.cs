// *** WARNING: this file was generated by pulumi-gen-eks. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Eks.Outputs
{

    /// <summary>
    /// Defines the core set of data associated with an EKS cluster, including the network in which it runs.
    /// </summary>
    [OutputType]
    public sealed class CoreData
    {
        public readonly Pulumi.Aws.Provider? AwsProvider;
        public readonly Pulumi.Aws.Eks.Cluster Cluster;
        public readonly Pulumi.Aws.Ec2.SecurityGroup ClusterSecurityGroup;
        public readonly Pulumi.Kubernetes.Core.V1.ConfigMap? EksNodeAccess;
        public readonly Pulumi.Aws.Eks.Outputs.ClusterEncryptionConfig? EncryptionConfig;
        public readonly string Endpoint;
        public readonly Pulumi.Aws.Eks.FargateProfile? FargateProfile;
        public readonly ImmutableArray<Pulumi.Aws.Iam.Role> InstanceRoles;
        public readonly object? Kubeconfig;
        public readonly Outputs.ClusterNodeGroupOptions NodeGroupOptions;
        public readonly ImmutableDictionary<string, string>? NodeSecurityGroupTags;
        public readonly Pulumi.Aws.Iam.OpenIdConnectProvider? OidcProvider;
        public readonly ImmutableArray<string> PrivateSubnetIds;
        public readonly Pulumi.Kubernetes.Provider Provider;
        public readonly ImmutableArray<string> PublicSubnetIds;
        public readonly ImmutableDictionary<string, Pulumi.Kubernetes.Storage.V1.StorageClass>? StorageClasses;
        public readonly ImmutableArray<string> SubnetIds;
        public readonly ImmutableDictionary<string, string>? Tags;
        public readonly Pulumi.Eks.VpcCni? VpcCni;
        public readonly string VpcId;

        [OutputConstructor]
        private CoreData(
            Pulumi.Aws.Provider? awsProvider,

            Pulumi.Aws.Eks.Cluster cluster,

            Pulumi.Aws.Ec2.SecurityGroup clusterSecurityGroup,

            Pulumi.Kubernetes.Core.V1.ConfigMap? eksNodeAccess,

            Pulumi.Aws.Eks.Outputs.ClusterEncryptionConfig? encryptionConfig,

            string endpoint,

            Pulumi.Aws.Eks.FargateProfile? fargateProfile,

            ImmutableArray<Pulumi.Aws.Iam.Role> instanceRoles,

            object? kubeconfig,

            Outputs.ClusterNodeGroupOptions nodeGroupOptions,

            ImmutableDictionary<string, string>? nodeSecurityGroupTags,

            Pulumi.Aws.Iam.OpenIdConnectProvider? oidcProvider,

            ImmutableArray<string> privateSubnetIds,

            Pulumi.Kubernetes.Provider provider,

            ImmutableArray<string> publicSubnetIds,

            ImmutableDictionary<string, Pulumi.Kubernetes.Storage.V1.StorageClass>? storageClasses,

            ImmutableArray<string> subnetIds,

            ImmutableDictionary<string, string>? tags,

            Pulumi.Eks.VpcCni? vpcCni,

            string vpcId)
        {
            AwsProvider = awsProvider;
            Cluster = cluster;
            ClusterSecurityGroup = clusterSecurityGroup;
            EksNodeAccess = eksNodeAccess;
            EncryptionConfig = encryptionConfig;
            Endpoint = endpoint;
            FargateProfile = fargateProfile;
            InstanceRoles = instanceRoles;
            Kubeconfig = kubeconfig;
            NodeGroupOptions = nodeGroupOptions;
            NodeSecurityGroupTags = nodeSecurityGroupTags;
            OidcProvider = oidcProvider;
            PrivateSubnetIds = privateSubnetIds;
            Provider = provider;
            PublicSubnetIds = publicSubnetIds;
            StorageClasses = storageClasses;
            SubnetIds = subnetIds;
            Tags = tags;
            VpcCni = vpcCni;
            VpcId = vpcId;
        }
    }
}
