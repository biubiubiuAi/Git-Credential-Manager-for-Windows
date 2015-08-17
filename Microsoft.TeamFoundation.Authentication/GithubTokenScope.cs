﻿using System;
using System.Runtime.CompilerServices;
using ScopeSet = System.Collections.Generic.HashSet<string>;

namespace Microsoft.TeamFoundation.Authentication
{
    public sealed class GithubTokenScope : TokenScope
    {
        public static readonly GithubTokenScope None = new GithubTokenScope(String.Empty);
        public static readonly GithubTokenScope Gist = new GithubTokenScope("gist");
        public static readonly GithubTokenScope Notifications = new GithubTokenScope("notifications");
        public static readonly GithubTokenScope OrgAdmin = new GithubTokenScope("admin:org");
        public static readonly GithubTokenScope OrgRead = new GithubTokenScope("read:org");
        public static readonly GithubTokenScope OrgWrite = new GithubTokenScope("write:org");
        public static readonly GithubTokenScope OrgHookAdmin = new GithubTokenScope("admin:org_hook");
        public static readonly GithubTokenScope PublicKeyAdmin = new GithubTokenScope("admin:public_key");
        public static readonly GithubTokenScope PublicKeyRead = new GithubTokenScope("read:public_key");
        public static readonly GithubTokenScope PublicKeyWrite = new GithubTokenScope("write:public_key");
        public static readonly GithubTokenScope Repo = new GithubTokenScope("repo");
        public static readonly GithubTokenScope RepoDelete = new GithubTokenScope("delete_repo");
        public static readonly GithubTokenScope RepoDeployment = new GithubTokenScope("repo_deployment");
        public static readonly GithubTokenScope RepoPublic = new GithubTokenScope("public_repo");
        public static readonly GithubTokenScope RepoStatus = new GithubTokenScope("repo:status");
        public static readonly GithubTokenScope RepoHookAdmin = new GithubTokenScope("admin:repo_hook");
        public static readonly GithubTokenScope RepoHookRead = new GithubTokenScope("read:repo_hook");
        public static readonly GithubTokenScope RepoHookWrite = new GithubTokenScope("write:repo_hook");
        public static readonly GithubTokenScope User = new GithubTokenScope("user");
        public static readonly GithubTokenScope UserEmail = new GithubTokenScope("user:email");
        public static readonly GithubTokenScope UserFollow = new GithubTokenScope("user:follow");

        private GithubTokenScope(string value)
            : base(value)
        { }

        private GithubTokenScope(string[] values)
            : base(values)
        { }

        private GithubTokenScope(ScopeSet set)
            : base(set)
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static GithubTokenScope operator +(GithubTokenScope scope1, GithubTokenScope scope2)
        {
            ScopeSet set = new ScopeSet();
            set.UnionWith(scope1._scopes);
            set.UnionWith(scope2._scopes);

            return new GithubTokenScope(set);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static GithubTokenScope operator -(GithubTokenScope scope1, GithubTokenScope scope2)
        {
            ScopeSet set = new ScopeSet();
            set.UnionWith(scope1._scopes);
            set.ExceptWith(scope2._scopes);

            return new GithubTokenScope(set);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static GithubTokenScope operator |(GithubTokenScope scope1, GithubTokenScope scope2)
        {
            ScopeSet set = new ScopeSet();
            set.UnionWith(scope1._scopes);
            set.UnionWith(scope2._scopes);

            return new GithubTokenScope(set);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static GithubTokenScope operator &(GithubTokenScope scope1, GithubTokenScope scope2)
        {
            ScopeSet set = new ScopeSet();
            set.UnionWith(scope1._scopes);
            set.IntersectWith(scope2._scopes);

            return new GithubTokenScope(set);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static GithubTokenScope operator ^(GithubTokenScope scope1, GithubTokenScope scope2)
        {
            ScopeSet set = new ScopeSet();
            set.UnionWith(scope1._scopes);
            set.SymmetricExceptWith(scope2._scopes);

            return new GithubTokenScope(set);
        }
    }
}
