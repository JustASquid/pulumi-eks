// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.eks.inputs;

import com.pulumi.aws.Provider;
import com.pulumi.aws.iam.Role;
import com.pulumi.core.annotations.Import;
import java.util.Objects;


/**
 * Contains the AWS Role and Provider necessary to override the `[system:master]` entity ARN. This is an optional argument used when creating `Cluster`. Read more: https://docs.aws.amazon.com/eks/latest/userguide/add-user-role.html
 * 
 * Note: This option is only supported with Pulumi nodejs programs. Please use `ProviderCredentialOpts` as an alternative instead.
 * 
 */
public final class CreationRoleProviderArgs extends com.pulumi.resources.ResourceArgs {

    public static final CreationRoleProviderArgs Empty = new CreationRoleProviderArgs();

    @Import(name="provider", required=true)
    private Provider provider;

    public Provider provider() {
        return this.provider;
    }

    @Import(name="role", required=true)
    private Role role;

    public Role role() {
        return this.role;
    }

    private CreationRoleProviderArgs() {}

    private CreationRoleProviderArgs(CreationRoleProviderArgs $) {
        this.provider = $.provider;
        this.role = $.role;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(CreationRoleProviderArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private CreationRoleProviderArgs $;

        public Builder() {
            $ = new CreationRoleProviderArgs();
        }

        public Builder(CreationRoleProviderArgs defaults) {
            $ = new CreationRoleProviderArgs(Objects.requireNonNull(defaults));
        }

        public Builder provider(Provider provider) {
            $.provider = provider;
            return this;
        }

        public Builder role(Role role) {
            $.role = role;
            return this;
        }

        public CreationRoleProviderArgs build() {
            $.provider = Objects.requireNonNull($.provider, "expected parameter 'provider' to be non-null");
            $.role = Objects.requireNonNull($.role, "expected parameter 'role' to be non-null");
            return $;
        }
    }

}
